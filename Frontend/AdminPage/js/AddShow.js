document.addEventListener('DOMContentLoaded', (event) => {
    
   

    //FetchMovies
    var url=ApiUrlCore+"Booking/GetAllMovies";

    fetch(url)
        .then(response =>{
            // Check if the request was successful
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
            // Handle the JSON data
            console.log(data);
            RenderMoviesList(data);
        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
            alert(error);
        });
    
    //RenderMoviesList
    function RenderMoviesList(movies){
        //Fetch Movies
        const MovieOption=document.getElementById('movie');
        MovieOption.innerHTML='';
        movies.forEach(movie => {
            const option=document.createElement('option');
            option.value=movie.movieId;
            option.innerText=movie.movieName;

            MovieOption.appendChild(option);
        });
    }

    //Fetch Screen
    var url=ApiUrlCore+"Booking/GetAllScreens";
    fetch(url)
        .then(response =>{
            // Check if the request was successful
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
            // Handle the JSON data
            console.log(data);
            RenderScreen(data);
        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
            alert(error);
        });
    
    //RenderScreens
    function RenderScreen(screens){
        //Fetch Screens
        const ScreenOption=document.getElementById('screen');
        ScreenOption.innerHTML='';
        screens.forEach(screen => {
            const option=document.createElement('option');
            option.value=screen.screenId;
            option.innerText=`${screen.screenName} (${screen.theaterName})`;
            
            ScreenOption.appendChild(option);
        });
    }

    //AddShow
    const AddShowForm=document.getElementById('add-show-form');
    AddShowForm.addEventListener('submit',function(event){
        event.preventDefault();
        let formData = new FormData(event.target);
        let movie=formData.get('movie')
        let screen=formData.get('screen');
        let datetime=formData.get('datetime');

        let ShowData={screenId:screen,movieId:movie,showDateTime:datetime};
        console.log(ShowData);

        var url=ApiUrlCore+"Booking/AddShow"

        var options={
            method: 'POST',
            headers: {
                'accept':'text/plain',
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+Admin.token
            },
            body: JSON.stringify(ShowData)
        }

        fetch(url,options)
            .then(response =>{
                // Check if the request was successful
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
                // Handle the JSON data
                console.log(data);
                alert("Show Added Successfully");
                window.location.reload();
            })
            .catch(error => {
                // Handle any errors that occurred during the fetch
                console.error('Fetch error:', error);
                alert(error);
            });
    });
});