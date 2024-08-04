//Core of the API
// var ApiUrlCore="http://localhost:5053/api/";
// var ApiUrlCore="http://4.242.48.188:3000/api/";
var ApiUrlCore="https://moviebooking-cfg8aqccdqawdmbx.westus2-01.azurewebsites.net/api/"


var district=localStorage.getItem('district');
if(!district){
    localStorage.setItem('district',"Chennai");
}