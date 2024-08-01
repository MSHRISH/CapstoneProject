//Load the details
document.addEventListener('DOMContentLoaded', function() {
    //get query parameters
    function getQueryParam(param) {
        const urlParams = new URLSearchParams(window.location.search);
        return urlParams.get(param);
    }

    
    const movieId = getQueryParam('movieid');

    // Return Home if no param
    if (!movieId) {
        window.location.href = "Home.html"; 
        return;
    }

   
    const url = ApiUrlCore+"Moive/GetMovieById?movieId="+movieId;
    console.log(url);
    // Fetch the movie details
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
            RenderMovieDetails(data); 
        })
        .catch(error => {
            console.error('There has been a problem with your fetch operation:', error);
        });

    // Render Movie Details
    function RenderMovieDetails(movie) {
    
        document.getElementById('movie-title').innerText = movie.title;
        document.getElementById('movie-title').name=movie.id;
        document.getElementById('movie-poster').src=movie.posterUrl;
        document.getElementById('movie-description').innerText=movie.description;
        document.getElementById('movie-letterboxd').href=movie.letterBoxUrl;
        document.getElementById('movie-language').innerText+=" "+movie.language.languageName;
        document.getElementById('movie-format').innerText+=" "+movie.format.formatName;
        document.getElementById('movie-certification').innerText+=" "+movie.certification.certificateType;

        const CastCrewContainer=document.getElementById('cast-crew-container');
        CastCrewContainer.innerHTML='';

        movie.castCrewDetails.forEach(castCrew => {
            const individual=document.createElement('span');
            individual.className="bg-gray-200 rounded-lg shadow-md px-3 py-1 hover:bg-slate-300";
            individual.innerText=castCrew.artistName+" ("+castCrew.role+")";       
            
            CastCrewContainer.appendChild(individual);
        });
    }

    //Shows Pages
    document.getElementById('book-button').addEventListener('click',function(event){
        console.log(district);
        console.log( document.getElementById('movie-title').name);
        window.location.href="Shows.html?movieid="
                            + document.getElementById('movie-title').name
                            +"&moviename="+document.getElementById('movie-title').innerText;
    });
});
