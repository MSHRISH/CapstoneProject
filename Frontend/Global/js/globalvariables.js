//Core of the API
var ApiUrlCore="http://localhost:5053/api/";


var district=localStorage.getItem('district');
if(!district){
    localStorage.setItem('district',"Chennai");
}