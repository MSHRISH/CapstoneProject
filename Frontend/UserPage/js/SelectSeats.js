//Load the details
document.addEventListener('DOMContentLoaded', function() {
    //get query parameters
    function getQueryParam(param) {
        const urlParams = new URLSearchParams(window.location.search);
        return urlParams.get(param);
    }

    //Globals
    const showid=getQueryParam('showid');
    const moviename=getQueryParam('moviename');
    const showtime=getQueryParam('showtime');
    const screenname=getQueryParam('screenname')
    var SelectedSeats=[];
    var Price=0;
    var SnackOrders={};
    var SnackPrice=0;
    

    // Return Home if no param
    if (!showid||!moviename||!showtime||!screenname) {
        alert(screenname);
        window.location.href = "Home.html"; 
        return;
    }

    document.getElementById('movie-name').innerText=moviename;
    document.getElementById('show-time').innerText=showtime;
    document.getElementById('screen-name').innerText=screenname;

    //Fetch SeatLayout
    url=ApiUrlCore+"Booking/GetScreenLayout?showId="+showid;

    fetch(url)
        .then(response => {
            if (!response.ok) {
                // If the response is not okay, parse the error response
                return response.json().then(errorData => {
                    // Throw a new error with the message from the error response
                    const errorMessage = errorData.message || 'Network response was not ok';
                    throw new Error(errorMessage);
                });
            }
            // Parse the response as JSON
            return response.json();
        })
        .then(data => {
            console.log(data);
            RenderSeats(data);
        })
        .catch(error => {
            console.error('There has been a problem with your fetch operation:', error);
        });
    
    //BookTicketButton
    const BookTicketButton=document.getElementById('book-tickets-button');
    BookTicketButton.addEventListener('click',function(event){
        BookTicketButton.classList.add('hidden');
        FetchDiscount();
    });

    //Cancell Booking
    const BookingCancelButton=document.getElementById('cancel-booking-button');
    BookingCancelButton.addEventListener('click',function(event){
        document.getElementById('discount-options').classList.add('hidden');
        document.getElementById('snack-options').classList.add('hidden');
        const OptionsModol=document.getElementById('options-modal');
        OptionsModol.classList.add('hidden');
        SnackOrders={}
        SnackPrice=0;
        BookTicketButton.classList.remove('hidden');
        const checkedOptions = document.querySelectorAll('input[name="option"]:checked');
        checkedOptions.forEach(option => {
            option.checked = false;
        });

    });

    //Confirm Booking
    const ConfirmBooking=document.getElementById('confirming-booking-button');
    ConfirmBooking.addEventListener('click',function(event){
        var BookingData={
            showId:showid,
            availDiscount:false,
            availSnack:false,
            seatsBooked:SelectedSeats,
            snacks:[]
        }
        //Avail Discounts
        const selectedOption = document.querySelector('input[name="option"]:checked');
        if(selectedOption){
            // alert(`Selected value: ${selectedOption.value}`);
            if(selectedOption.value=="discount"){
                BookingData.availDiscount=true;
            }
            if(selectedOption.value=="popcorn"){
                BookingData.availSnack=true;
            }
        }
        for (let snack in SnackOrders) {
            BookingData.snacks.push({snackID:snack,quantity:SnackOrders[snack]});
        }

        console.log(BookingData);

        //Fetch Booking
        var url=ApiUrlCore+"Booking/Makebooking";
        var options={
            method: 'POST',
            headers: {
                'accept':'text/plain',
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+User.token
            },
            body: JSON.stringify(BookingData)
        }

        fetch(url,options)
            .then(response => {
                if (!response.ok) {
                    // If the response is not okay, parse the error response
                    return response.json().then(errorData => {
                        // Throw a new error with the message from the error response
                        const errorMessage = errorData.message || 'Network response was not ok';
                        throw new Error(errorMessage);
                    });
                }
                // Parse the response as JSON
                return response.json();
            })
            .then(data => {
                console.log(data);
                alert("Redirecting to Payments Page");
                window.location.href="PaymentPage.html?bookingid="+data.bookingId;
                
            })
            .catch(error => {
                console.error('There has been a problem with your fetch operation:', error);
                alert(error);
                location.reload();
            });
    });

    //FetchDiscount
    function FetchDiscount(){
        url=ApiUrlCore+"Booking/CheckDiscountEligibility";
     
        const options = {
            method: 'GET', 
            headers: {
              'Authorization': "Bearer "+User.token
            }
        };

        fetch(url,options)
            .then(response => {
                if (!response.ok) {
                    // If the response is not okay, parse the error response
                    return response.json().then(errorData => {
                        // Throw a new error with the message from the error response
                        const errorMessage = errorData.message || 'Network response was not ok';
                        throw new Error(errorMessage);
                    });
                }
                // Parse the response as JSON
                return response.json();
            })
            .then(data => {
                console.log(data); 
                RenderOptionsModol(data);
             })
             .catch(error => {
                 console.error('There has been a problem with your fetch operation:', error);
             });
    }

    //Render Options Modol
    function RenderOptionsModol(eligibility){
        const OptionsModol=document.getElementById('options-modal');
        if(eligibility){
            document.getElementById('discount-options').classList.remove('hidden');
        }

        ConfirmBooking.innerText="Pay Rs."+Price;
        FetchSnacks();
        OptionsModol.classList.remove('hidden');
    }

    
    //Render Snacks Container
    function RenderSnacks(snacks){
        if(snacks.length==0){
            return;
        }
        const SnackContainer=document.getElementById('snack-container');
        
        SnackContainer.innerHTML='';
        snacks.forEach(snack => {
            //Snack row div
            const SnackDiv=document.createElement('div')
            SnackDiv.className="grid grid-cols-3 gap-8 border-2 px-2 py-1";

            const SnackNameSpan=document.createElement('span');
            SnackNameSpan.innerText=snack.snackName;

            const SnackPriceSpan=document.createElement('span');
            SnackPriceSpan.innerText=snack.price;

            //plus minus
            const PlusMinusDiv=document.createElement('div');
            PlusMinusDiv.className="flex flex-row gap-2";

            const MinusButton=document.createElement('button');
            MinusButton.className="border  text-red-500 border-red-500 rounded h-8 px-2";
            MinusButton.id=snack.id;
            MinusButton.name="MinusButton";
            MinusButton.innerText="-";
            MinusButton.disabled=true;


            const QuantitySpan=document.createElement('span');
            QuantitySpan.innerText="Add";

            MinusButton.addEventListener('click',function(event){
                // console.log(MinusButton.id);
                SnackOrders[MinusButton.id]-=1;
                SnackPrice-=snack.price;
                
                let total= parseFloat(Price)+ parseFloat(SnackPrice);
                ConfirmBooking.innerText="Pay Rs."+total;
                

                if(SnackOrders[MinusButton.id]==0){
                    QuantitySpan.innerText="Add";
                    MinusButton.disabled=true;
                    delete SnackOrders[MinusButton.id]
                    return;
                }
                QuantitySpan.innerText=SnackOrders[MinusButton.id];
                console.log(SnackOrders);
            });

            const PlusButton=document.createElement('button');
            PlusButton.className='border text-green-500 border-green-500 rounded h-8 px-2';
            PlusButton.id=snack.id;
            PlusButton.name="PlusButton";
            PlusButton.innerText="+";

            PlusButton.addEventListener('click',function(event){
                // console.log(PlusButton.id);
                SnackPrice+=snack.price;
                let total= parseFloat(Price)+ parseFloat(SnackPrice);
                ConfirmBooking.innerText="Pay Rs."+total;
                
                if(PlusButton.id in SnackOrders){
                    SnackOrders[PlusButton.id]+=1;
                }
                else{
                    SnackOrders[PlusButton.id]=1;
                    
                    MinusButton.disabled=false; 
                }
                QuantitySpan.innerText=SnackOrders[PlusButton.id];
                console.log(SnackOrders);
            });

            PlusMinusDiv.appendChild(MinusButton);
            PlusMinusDiv.appendChild(QuantitySpan);
            PlusMinusDiv.appendChild(PlusButton);

           
            

            SnackDiv.appendChild(SnackNameSpan);
            SnackDiv.appendChild(SnackPriceSpan);
            SnackDiv.appendChild(PlusMinusDiv);

            SnackContainer.appendChild(SnackDiv);
        });
        
        let total= parseFloat(Price)+ parseFloat(SnackPrice);
        ConfirmBooking.innerText="Pay Rs."+total;
                
        document.getElementById('snack-options').classList.remove('hidden');
    }

    
    //Render SeatLayout
    function RenderSeats(seatlayout){
        const RowDimension=seatlayout.rowDimension;
        const ColumnDimension=seatlayout.columnDimension;
        var seatindex=0;

        //seat layout container
        const SeatLayoutContainer=document.getElementById('seat-layout-container');
        SeatLayoutContainer.innerHTML='';

        //Row
        let  CurrentRowNumber=1
        for (let row = 1; row <= RowDimension; row++) {
            //Row Div
            const RowDiv=document.createElement('div');
            RowDiv.className="flex flex-row gap-4";

            //Column
            let CurrentSeatNumber=1 //To number the seats in the row
            let BoolIsRowEmpty=true; //To know if the entire row is empty
            
            for(let col=1; col <= ColumnDimension; col++){
                console.log(seatlayout.seats[seatindex]);
                //seat Div
                const SeatDiv=document.createElement('div');
                SeatDiv.id=seatlayout.seats[seatindex].id;
                SeatDiv.name=seatlayout.seats[seatindex].price;
                //Checking if it is seat
                if(seatlayout.seats[seatindex].isSeat){
                    BoolIsRowEmpty=false;
                    SeatDiv.className="h-10 w-10 border border-black text-center py-2";
                    SeatDiv.innerText=CurrentSeatNumber;
                    CurrentSeatNumber++;

                    //Check availability
                    if(!seatlayout.seats[seatindex].isAvailable){
                        SeatDiv.classList.add("bg-gray-300", "text-[snow]");
                    }
                    else{
                        //addeventlistener
                        SeatDiv.classList.add("hover:bg-green-500","cursor-pointer");
                        SeatDiv.addEventListener('click',function(event){
                            //If the seat is already selected
                            if(SelectedSeats.includes(SeatDiv.id)){
                                const index = SelectedSeats.indexOf(SeatDiv.id);
                                SelectedSeats.splice(index, 1);
                                SeatDiv.classList.remove("bg-green-500");
                                Price=Price-SeatDiv.name;
                                if(Price==0){
                                    BookTicketButton.classList.add('hidden');
                                }
                                BookTicketButton.innerText="Pay Rs. "+Price;
                            }
                            else{
                                if(SelectedSeats.length==5){
                                    alert("Can't Select more than 5 seats");
                                }
                                else{
                                    SelectedSeats.push(SeatDiv.id);
                                    SeatDiv.classList.add("bg-green-500");
                                    Price=Price+SeatDiv.name;
                                    BookTicketButton.classList.remove('hidden');
                                    BookTicketButton.innerText="Pay Rs. "+Price;
                                }
                            }
                            console.log(SelectedSeats);
                            console.log(Price);
                        });
                    }
                }                
                else{
                    SeatDiv.className="w-10";
                }
                RowDiv.appendChild(SeatDiv);
                seatindex++;
            }
            const RowLableDiv=document.createElement('div');
            RowLableDiv.className="mt-2 w-10";
            //Check if row is empty
            if(!BoolIsRowEmpty){
                RowLableDiv.innerText=CurrentRowNumber;
                CurrentRowNumber++;
            }
            RowDiv.prepend(RowLableDiv);
            SeatLayoutContainer.appendChild(RowDiv);
        }

        const ScreenDiv=document.createElement('div');
        ScreenDiv.className="flex  mb-6  items-center justify-center";
        
        const Screen=document.createElement('div');
        Screen.className="text-center border-2 w-[300px] h-8 border-black mb";
        Screen.innerText="Screen";

        ScreenDiv.appendChild(Screen);
        SeatLayoutContainer.appendChild(ScreenDiv);
        console.log("seatindex: ",seatindex);
    }

    //Fetch Snacks
    function FetchSnacks(){
        var url=ApiUrlCore+"Theater/GetSnacksForShow?showid="+showid;
        fetch(url)
            .then(response => {
                if (!response.ok) {
                    // If the response is not okay, parse the error response
                    return response.json().then(errorData => {
                        // Throw a new error with the message from the error response
                        const errorMessage = errorData.message || 'Network response was not ok';
                        throw new Error(errorMessage);
                    });
                }
                // Parse the response as JSON
                return response.json();
            })
            .then(data => {
                console.log(data); 
                RenderSnacks(data);
             })
             .catch(error => {
                console.error('There has been a problem with your fetch operation:', error);
            });
    }

    

});