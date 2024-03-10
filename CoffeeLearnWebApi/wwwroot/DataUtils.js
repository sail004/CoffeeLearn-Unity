var login = "login";
var tokenKey = "accessToken";
async function getData(url) {
    const token = sessionStorage.getItem(tokenKey);

    const response = await fetch(url, {
        method: "GET",
        headers: {
            "Accept": "application/json",
            "Authorization": "Bearer " + token
        }
    });
    if (response.ok === true) {

        const res = await response.json();
        return res;

    }
    else {
        console.log("Status: ", response.status);
        return null;
    }
};