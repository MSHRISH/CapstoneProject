loginForm=document.getElementById("user-login-form");

loginForm.addEventListener("submit",function(event){
    event.preventDefault();
    let formData = new FormData(event.target);
    let email=formData.get("email-input");
    let password=formData.get("password-input");
    let loginData={email:email,password:password};
    //console.log(loginData);

    let options={
        method:'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body:JSON.stringify(loginData)
    }

    var url=ApiUrlCore+"Access/UserLogin"

    fetch(url, options)
        .then(response => {
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
            localStorage.setItem('UserToken', JSON.stringify(data));
            alert("Login Successfull Redirecting to Dashboard");
            window.location.href='../UserPage/Home.html';
        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
            alert(error);
        });
});