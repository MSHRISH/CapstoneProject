//Load the details
document.addEventListener('DOMContentLoaded', function() {
    //get query parameters
    function getQueryParam(param) {
        const urlParams = new URLSearchParams(window.location.search);
        return urlParams.get(param);
    }

    const movieId = getQueryParam('movieid');
    const movieName= getQueryParam('moviename')
    var CurrentDate;

     // Return Home if no param
     if (!movieId) {
        window.location.href = "Home.html"; 
        return;
    }

    if(!movieName){
        alert("moviemname")
        window.location.href="Home.html"
        return;
    }

    document.getElementById('movie-name').innerText=movieName;


    const url = ApiUrlCore+"Booking/GetDatesOfMovie?movieId="+movieId+"&district="+localStorage.getItem('district');

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
           RenderDates(data);
           CurrentDate=data[0];
           FetchShows(data[0],movieId);
        })
        .catch(error => {
            console.error('There has been a problem with your fetch operation:', error);
        });
    
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
    
    //Render Dates 
    function RenderDates(dates){
        const DatesContainer=document.getElementById('dates-container');
        DatesContainer.innerHTML='';
        
       
        dates.forEach(date => {
            const DateDiv=document.createElement('div');
            DateDiv.id=date;

            DateDiv.className="bg-gray-200 px-3 py-1 flex flex-col justify-center items-center h-full cursor-pointer";
            const [DD, MM, DayOfWeek] = extractDateDetails(date)

            const DayOfWeekSpan=document.createElement('span');
            DayOfWeekSpan.innerText=DayOfWeek;

            const DDSpan=document.createElement('span');
            DDSpan.innerText=DD;

            const MMSpan=document.createElement('span');
            MMSpan.innerText=MM;

            DateDiv.appendChild(DayOfWeekSpan);
            DateDiv.appendChild(DDSpan);
            DateDiv.appendChild(MMSpan);

            DateDiv.addEventListener('click',function(event){
                // DateDiv.classList.remove('bg-green-500');
                FetchShows(date,movieId);
            });

            DatesContainer.appendChild(DateDiv);
        });
    }

    //Fetch Shows
    function FetchShows(date,movieid){
        document.getElementById(CurrentDate).classList.remove('bg-green-500')
        CurrentDate=date;
        document.getElementById(date).classList.add('bg-green-500')
        var url=ApiUrlCore+"Booking/GetMovieShowsByDateDistrict?movieId="+movieid
                +"&district="+localStorage.getItem('district')
                +"&date="+date;

        console.log(url);
        
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
                RenderShows(data); 
            })
            .catch(error => {
                console.error('There has been a problem with your fetch operation:', error);
            });
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

    //RenderShows
    function RenderShows(shows){
        
        const container=document.getElementById('theater-show-container');
        container.innerHTML='';
        Object.keys(shows).forEach(theater => {
            const TheaterDiv=document.createElement('div');
            TheaterDiv.className="bg-white p-4 rounded-lg shadow-md";

            const Theatername=document.createElement('h3')
            Theatername.className="text-xl font-bold mb-2";
            Theatername.innerText=theater;

            const ShowContainer=document.createElement('div');
            ShowContainer.className="flex flex-wrap gap-2";

            shows[theater].forEach(show => {
                const ShowDiv=document.createElement('div');
                ShowDiv.className="bg-gray-200 rounded-lg px-3 py-1 flex flex-col justify-center items-center h-full hover:bg-green-500 cursor-pointer";
                ShowDiv.id=show.id;

                const ShowTimeSpan=document.createElement('span');
                ShowTimeSpan.innerText=ExtractTime(show.showDateTime);
                
                const ScreenNameSpan=document.createElement('span');
                ScreenNameSpan.innerText=show.screenName;

                ShowDiv.appendChild(ShowTimeSpan);
                ShowDiv.appendChild(ScreenNameSpan);
            
                ShowContainer.appendChild(ShowDiv);
            });

            TheaterDiv.appendChild(Theatername);
            TheaterDiv.appendChild(ShowContainer);
            container.appendChild(TheaterDiv);
        });
    }
});