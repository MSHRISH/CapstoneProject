//Core of the API
var ApiUrlCore="http://localhost:5053/api/";
// var ApiUrlCore="http://20.70.200.60:3000/api/";


var district=localStorage.getItem('district');
if(!district){
    localStorage.setItem('district',"Chennai");
}