//JWT Token Rip-Open Test
function jwtRipOpen(token){
    const parts = token.split('.');

    if (parts.length !== 3) {
        alert('Invalid JWT.');
        return;
    }

    const base64Url = parts[1];
    const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
    const jsonPayload = decodeURIComponent(atob(base64).split('').map(c => {
        return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
    }).join(''));

    const payload = JSON.parse(jsonPayload);
    // console.log(payload["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"]);
    // console.log(payload["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]);
    // console.log(payload["exp"]);
    // console.log(JSON.stringify(payload,null,2))
    return payload;
}

//Validating a User Token
function validateUserToken(decodedToken){
    if(decodedToken["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"]!='User'){
        return false;
    }
    const currentTime = Math.floor(Date.now() / 1000);

    if (decodedToken['exp'] && currentTime < decodedToken['exp']) {
        return true;
    } else {
        return false;
    }
}

//User Token
const User = JSON.parse(localStorage.getItem('AdminToken'));

//If Token not present
if(User){
    window.location.href="../AdminPage/AddShow.html"; 
}