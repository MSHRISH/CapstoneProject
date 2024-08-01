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