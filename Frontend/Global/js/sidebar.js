var menuButton = document.getElementById('menu-button');
var closeButton = document.getElementById('close-button');
var sidebar = document.getElementById('sidebar');

menuButton.addEventListener('click', function(event) {
    sidebar.classList.add('absolute');
    sidebar.classList.remove('hidden');
    sidebar.classList.add('slide-in');
    setTimeout(() => {
        closeButton.classList.remove('hidden');
        }, 500);

});

closeButton.addEventListener('click', function(event) {
    
    sidebar.classList.remove('slide-in');
    sidebar.classList.add('slide-out');
    closeButton.classList.add('hidden');


          
    setTimeout(() => {
        sidebar.classList.remove('absolute');
        sidebar.classList.add('hidden');
        sidebar.classList.remove('slide-out');
        }, 500); 
    });