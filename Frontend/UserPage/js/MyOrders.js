 //Extracting Date Details
 function extractDateDetails(dateString) {
    const date = new Date(dateString);  // Parse the date string to a Date object
    const day = date.getDate().toString().padStart(2, '0');  // Get the day with leading zero
    const monthNames = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    const month = monthNames[date.getMonth()];  // Get the month name
    const dayNames = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];
    const dayOfWeek = dayNames[date.getDay()];  // Get the day of the week name
    const year = date.getFullYear();
    return [day, month, dayOfWeek,year];
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



document.addEventListener('DOMContentLoaded', function() {
    var url=ApiUrlCore+"Booking/GetAllMyBookings";
    var options={
        method: 'GET',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+User.token
            },
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
            RenderOrders(data);
            
        })
        .catch(error => {
            console.error('There has been a problem with your fetch operation:', error);
            alert(error);
            // window.location.href="Home.html";
        });
    
    //RenderOrders
    function RenderOrders(orders){
        const OrderContainer=document.getElementById('orders-container');
        OrderContainer.innerHTML=''
        orders.forEach(order => {
             const TicketContainer=document.createElement('div');
             TicketContainer.id=order.bookingId;
             TicketContainer.className="cursor-pointer hover:bg-gray-200 h-fit  w-full bg-white rounded-lg items-center flex flex-col py-2 px-2";
             const [DD, MM, DayOfWeek,year] = extractDateDetails(order.showDateTime);
             const [OrderDate, orderMonth, OrderDay,orrderYear] = extractDateDetails(order.bookedOn);
            
             TicketContainer.innerHTML = `
                <div class="font-bold text-xl mb-2 border-2 flex gap-1 justify-center w-full h-fit px-2 rounded-lg bg-slate-400">
                    <span id="movie-name">${order.movieName}</span>
                    <span id="certificate">( ${order.certification} )</span>
                </div>
                <div class="mb-2 border-2 flex justify-center gap-1 h-fit px-2 bg-slate-300 rounded-lg">
                    <span id="lang-format">${order.language}, ${order.format}</span>
                </div>
                <div class="font-bold text-xl mb-2 border-2 flex flex-col items-center justify-center w-fit h-fit px-2 rounded-lg bg-slate-400">
                    <span id="theater">${order.theaterName}</span>
                    <span id="screen">${order.screenName}</span>
                </div>
                <div class="mb-2 border-2 flex justify-center gap-1 h-fit px-2 bg-slate-300 rounded-lg">
                    <span id="show-date">${DayOfWeek}, ${DD} ${MM}</span>
                    <span>|</span>
                    <span id="show-time">${ExtractTime(order.showDateTime)}</span>
                </div>
                <div class="w-32 truncate">
                    <span id="tickets">${order.bookedSeats.length} Ticket(s): ${order.bookedSeats.join(", ")}</span>
                </div>
                <div class="flex flex-col sm:flex-row gap-1 text-wrap">
                    <span>Ordered On: </span>
                    <span class="font-bold">${OrderDate} ${orderMonth}, ${orrderYear}</span>
                    <span class="font-bold">at ${ExtractTime(order.bookedOn)}</span>
                </div>
            `;
            TicketContainer.addEventListener('click',function(event){
                window.location.href="Ticket.html?bookingid="+TicketContainer.id;
            });
            OrderContainer.appendChild(TicketContainer);
        });

    }

   
});