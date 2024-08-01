const LogoutSidebarButton=document.getElementById('logout-sidebar');
const LogoutModol=document.getElementById('logout-modal');
const LogoutCancelButton=document.getElementById('logout-cancel-Button');
const LogoutButton=document.getElementById('logout-button');

//Sidebar button
LogoutSidebarButton.addEventListener('click',function(event){
    LogoutModol.classList.remove('hidden');
});


//District change button
LogoutButton.addEventListener('click',function(event){
    alert("Logged Out Successfully");
    localStorage.removeItem('UserToken');
    window.location.href="../AccessPages/UserLogin.html";
});

//CancelButton
LogoutCancelButton.addEventListener('click',function(event){
    LogoutModol.classList.add('hidden');
});

//Cancell Anywhere click
window.addEventListener('click', (event) => {
    if (event.target === LogoutModol) {
        LogoutModol.classList.add('hidden');
    }
});