const sidebarDistrict=document.getElementById('change-district-sidebar');
const districtChangeModol=document.getElementById('district-modal');
const districtCancelButton=document.getElementById('district-cancel-button');
const districtChangeButton=document.getElementById('change-district-button');

//Default Value from global district
const selectElement = document.getElementById('district-select');
selectElement.value = localStorage.getItem('district');

//Sidebar button
sidebarDistrict.addEventListener('click',function(event){
    districtChangeModol.classList.remove('hidden');
});

//District change button
districtChangeButton.addEventListener('click',function(event){
    localStorage.setItem('district',selectElement.value);
    FetchMovies(localStorage.getItem('district'))
    document.getElementById('change-district-sidebar').innerHTML=localStorage.getItem('district');
    districtChangeModol.classList.add('hidden');
});

//CancelButton
districtCancelButton.addEventListener('click',function(event){
    districtChangeModol.classList.add('hidden');
});

//Cancell Anywhere click
window.addEventListener('click', (event) => {
    if (event.target === districtChangeModol) {
        districtChangeModol.classList.add('hidden');
    }
});