//get query parameters
function getQueryParam(param) {
    const urlParams = new URLSearchParams(window.location.search);
    return urlParams.get(param);
}

 //Extracting Date Details
 function extractDateDetails(dateString) {
    const date = new Date(dateString);  // Parse the date string to a Date object
    const day = date.getDate().toString().padStart(2, '0');  // Get the day with leading zero
    const monthNames = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    const month = monthNames[date.getMonth()];  // Get the month name
    const dayNames = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
    const dayOfWeek = dayNames[date.getDay()];  // Get the day of the week name
    return [day, month, dayOfWeek];
}

 //Extract Time
 function ExtractTime(dateString) {
    const date = new Date(dateString);  // Create a Date object from the date string

    // Get hours and minutes
    let hours = date.getHours();
    const minutes = date.getMinutes().toString().padStart(2, '0');  // Ensure two digits for minutes

    // Determine AM or PM
    const ampm = hours >= 12 ? 'PM' : 'AM';

    // Convert to 12-hour format
    hours = hours % 12;
    hours = hours ? hours : 12;  // The hour '0' should be '12'

    // Format the time string
    return `${hours}:${minutes} ${ampm}`;
}


function DeleteBooking(bookingid){
    localStorage.setItem('test',bookingid);    
    var url=ApiUrlCore+"Booking/DeleteBooking?bookingId="+bookingid;
    var options={
        method: 'DELETE',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+User.token
            },
    }

    fetch(url,options);
    window.location.href="Home.html";
}

window.addEventListener('beforeunload', function(event){
    DeleteBooking(getQueryParam('bookingid'));
    window.location.href="Home.html";
});


document.addEventListener('DOMContentLoaded', function() {
     
    const bookingId=getQueryParam('bookingid');

    if(!bookingId){
        window.location.href="Home.html";
    }

    //Check if the booking id is valid
    var url=ApiUrlCore+"Booking/GetMyBookingById?bookingId="+bookingId;
    var options={
        method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+User.token
            },
    }
    console.log(url)

    //Fetch the Booking Details
    fetch(url,options)
        .then(response =>{
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
            if(data.paymentStatus){
                window.location.href="Ticket.html?bookingid="+bookingId;
            }
            RenderBooking(data);
        })
        .catch(error => {
            console.error('There has been a problem with your fetch operation:', error);
            alert(error);
            // window.location.href="Home.html";
        });
    
    //Render Booking Details
    function RenderBooking(booking){
        document.getElementById('movie-name').innerText=booking.movieName;
        document.getElementById('certificate').innerText="( "+booking.certification+" )";
        document.getElementById('lang-format').innerText=booking.language+", "+booking.format;
        document.getElementById('theater').innerText=booking.theaterName;
        document.getElementById('screen').innerText=booking.screenName;
        const [DD, MM, DayOfWeek] = extractDateDetails(booking.showDateTime);
        document.getElementById('show-date').innerText=DayOfWeek+", "+DD+" "+MM;
        document.getElementById('show-time').innerText=ExtractTime(booking.showDateTime);

        document.getElementById('tickets').innerText=booking.bookedSeats.length+" Tickets(s)";

        const TicketContainer=document.getElementById('ticket-container');
        TicketContainer.innerHTML=''
        booking.bookedSeats.forEach(seat=> {
            const SeatSpan=document.createElement('span');
            SeatSpan.className="bg-gray-200 rounded-lg px-2 py-1";
            SeatSpan.innerText=seat;
            TicketContainer.appendChild(SeatSpan);
        });

        if(booking.snacks.length!=0){
            const SnackContainer=document.getElementById('snack-container');
            SnackContainer.innerHTML=""
            SnackContainer.classList.remove('hidden');
            booking.snacks.forEach(snack => {
                const SnackDiv=document.createElement('div');
                SnackDiv.innerText=snack.snackName+" x "+snack.quantity;
                SnackContainer.appendChild(SnackDiv);
            });
            document.getElementById('snack-amount').innerText=`Snack Amount: ${booking.snackAmount}`
        }

        document.getElementById('ticket-amount').innerText=`TicketAmount: ${booking.ticketAmount}`;
        if(booking.discount!=0){
            document.getElementById('discount').innerText=`Discount: ${booking.discount} %`;
        }
        document.getElementById('total-amount').innerText=`Total Amount: ${booking.totalAmount}`
        
        document.getElementById('pay-button').innerText=`Pay Rs. ${booking.totalAmount}`
    }

    //Payment Button
    document.getElementById('pay-button').addEventListener('click',function(event){
        var url=ApiUrlCore+"Booking/MakePayment?bookingId="+bookingId;
        options={
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+User.token
            }
        }
        fetch(url,options)
            .then(response =>{
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
                alert("Payed Successfully");
                window.location.href="Ticket.html?bookingid="+bookingId;
                
            })
            .catch(error => {
                console.error('There has been a problem with your fetch operation:', error);
                alert(error);
            });
    });

    //Cancel Button
    document.getElementById('cancel-button').addEventListener('click',function(event){
        var userResponse = confirm("Do you want to cancel?");
        if (userResponse) {
            DeleteBooking(bookingId);
        }
        
    });
});