//REndering the Movies by district
function FetchMovies(district){
    console.log("Home.js",district);
    var url=ApiUrlCore+"Booking/GetMoviesRunningInDistrict?district="+district;
    fetch(url)
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
        console.log(data);  // Handle your data here
        RenderHome(data);
    })
    .catch(error => {
        // Handle any errors that occurred during the fetch
        console.error('Fetch error:', error);
        alert(error);
    });
}

FetchMovies(localStorage.getItem('district'));

function RenderHome(movies){
    console.log(movies.length);
    const MovieContainer=document.getElementById('movie-container');
    MovieContainer.innerHTML='';
    const errorContainer=document.getElementById('error-container');
    errorContainer.innerHTML='';
    errorContainer.className=""
    if(movies.length==0){
        errorContainer.className="w-full h-full flex items-center justify-center"
        const errorDiv=document.createElement('div')
        errorDiv.className="font-bold text-red-500 text-4xl text-center border-2 px-2 py-1 border-red-500"
        errorDiv.innerText="Sorry no movies found in the location";
        errorContainer.appendChild(errorDiv);
        return;
    }
    else{
        movies.forEach(movie => {
            const MovieDiv=document.createElement('div');
            MovieDiv.className="flex flex-col bg-gray-400 p-2 rounded-xl border-2 hover:border-[black] shadow-xl cursor-pointer hover:bg-slate-400";
            MovieDiv.id=movie.id;
            MovieDiv.addEventListener('click',function(event){
                window.location.href="MovieDetail.html?movieid="+movie.id;
            });

            const Poster=document.createElement('img');
            Poster.className="h-auto w-auto";
            Poster.src=movie.posterUrl;
            Poster.alt="Error";

            const MovieTitle=document.createElement('p');
            MovieTitle.className="mt-2 text-center font-bold";
            MovieTitle.innerText=movie.title;

            MovieDiv.appendChild(Poster);
            MovieDiv.appendChild(MovieTitle);

            MovieContainer.appendChild(MovieDiv);
    });
    }
    
}

document.addEventListener('DOMContentLoaded', function() {
    document.getElementById('change-district-sidebar').innerText=localStorage.getItem('district');
})