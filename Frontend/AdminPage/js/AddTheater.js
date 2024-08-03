// const nameInput=document.getElementById('district');
// const nameError=document.getElementById('district-error'); 

// nameInput.addEventListener('input',function(event){
//     if(!nameInput.validity.valid){
//         nameError.classList.remove('hidden');
//     }
//     else{
//         nameError.classList.add('hidden');
//     }
// });

const phoneInput = document.getElementById('phone-input');
const phoneError=document.getElementById('phone-error')
     
phoneInput.addEventListener('input',function(event){
    if(!phoneInput.validity.valid){
        phoneError.classList.remove('hidden');
    }
    else{
        phoneError.classList.add('hidden');
    }
});


document.getElementById('add-theater-form').addEventListener('submit',function(event){
    event.preventDefault();
    let formData = new FormData(event.target);
    let theatername=formData.get('theater-name');
    let phone=formData.get('phone-input');
    let address=formData.get('address');
    let district=formData.get('district');

    let TheaterData={name:theatername,phone:phone,address:address,district:district}
    console.log(TheaterData);

    var url=ApiUrlCore+"Theater/AddTheater"

    var options={
        method: 'POST',
        headers: {
            'accept':'text/plain',
            'Content-Type': 'application/json',
            'Authorization': "Bearer "+Admin.token
        },
        body: JSON.stringify(TheaterData)
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
        alert("Theater Added Successfully");
        window.location.reload();
    })
    .catch(error => {
        // Handle any errors that occurred during the fetch
        console.error('Fetch error:', error);
        alert(error);
    });

});
