document.addEventListener('DOMContentLoaded', (event) => {
    //Fetch Theaters
    //FetchMovies
    var url=ApiUrlCore+"Theater/GetAllTheaters";

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
            RenderTheater(data);
        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
            alert(error);
        });
    
    //Render theaters
    function RenderTheater(theaters){
        const TheaterOption=document.getElementById('theater');
        TheaterOption.innerHTML='';
        theaters.forEach(theater => {
            const option=document.createElement('option');
            option.value=theater.theaterId;
            option.innerText=theater.theaterName;

            TheaterOption.appendChild(option);
        });
    }

    //Fetch Layout
    var url=ApiUrlCore+"Theater/GetAllSchemas";

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
            RenderLayout(data);
        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
            alert(error);
        });
    
    //Render Layouts
    function RenderLayout(layouts){
        const LayoutOption=document.getElementById('layout');
        LayoutOption.innerHTML='';
        layouts.forEach(layout => {
            const option=document.createElement('option');
            option.value=layout.schemaId;
            option.innerText=layout.schemaName;

            LayoutOption.appendChild(option);
        });
    }

    //Add Screen
    document.getElementById('add-screen-form').addEventListener('submit',function(event){
        event.preventDefault();
        let formData = new FormData(event.target);
        let theater=formData.get('theater')
        let layout=formData.get('layout');
        let screenname=formData.get('screen-name');

        let ScreenData={theaterId:theater,screenName:screenname,schemaId:layout};
        console.log(ScreenData);

        var url=ApiUrlCore+"Theater/AddScreen"

        var options={
            method: 'POST',
            headers: {
                'accept':'text/plain',
                'Content-Type': 'application/json',
                'Authorization': "Bearer "+Admin.token
            },
            body: JSON.stringify(ScreenData)
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
                alert("Screen Added Successfully");
                window.location.reload();
            })
            .catch(error => {
                // Handle any errors that occurred during the fetch
                console.error('Fetch error:', error);
                alert(error);
            });
            
    });


})