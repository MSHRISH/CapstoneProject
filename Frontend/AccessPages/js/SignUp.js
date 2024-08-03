const nameInput=document.getElementById('name-input');
const nameError=document.getElementById('name-error'); 

nameInput.addEventListener('input',function(event){
    if(!nameInput.validity.valid){
        nameError.classList.remove('hidden');
    }
    else{
        nameError.classList.add('hidden');
    }
});



const emailInput=document.getElementById('email-input');
const emailError=document.getElementById('email-error');

emailInput.addEventListener('input',function(event){
    if(!emailInput.validity.valid){
        emailError.classList.remove('hidden');
    }
    else{
        emailError.classList.add('hidden');
    }
});

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

const passwordInput=document.getElementById('password-input');
const passwordError=document.getElementById('password-error');

passwordInput.addEventListener('input',function(event){
    if(!passwordInput.validity.valid){
        passwordError.classList.remove('hidden');
    }
    else{
        passwordError.classList.add('hidden');
    }
});


//Form Catch and Submit
const SignupForm=document.getElementById('user-signup-form');

SignupForm.addEventListener('submit',function(event){
    event.preventDefault();
    let formData = new FormData(event.target);
    let name=formData.get("name-input");
    let email=formData.get("email-input");
    let phone=formData.get("phone-input");
    let password=formData.get("password-input");

    let signupData={name:name,email:email,phone:phone,password:password};
    console.log(signupData);

    var options={
        method:'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body:JSON.stringify(signupData)
    }

     var url=ApiUrlCore+"Access/UserSignup";
     
     fetch(url,options)
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
            alert("Signup Successfull Redirecting to Login Page");
            window.location.href='AccessPages/UserLogin.html';
        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
            alert(error);
        });
});