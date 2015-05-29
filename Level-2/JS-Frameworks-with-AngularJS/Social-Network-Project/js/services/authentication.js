app.factory('authentication', ['$localStorage', function($localStorage){

    function checkForAccessToken() {
        return $localStorage.access_token !== undefined;
    }

    function saveUserData(data) {
        $localStorage.$default({
            access_token: data.access_token,
            token_type: data.token_type,
            username: data.userName
        });
    }

    function clearAuthenticationStorage() {
        $localStorage.$reset();
    }

    function getHeaders() {
        var headers = {};

        if (checkForAccessToken()) {
            headers.Authorization =
                getUserData().token_type.capitalizeFirstLetter() + ' ' + getUserData().access_token;
        }

        return headers;
    }

    function getUsername() {
        return getUserData().username;
    }

    function getUserData() {
        return $localStorage;
    }


    return {
        isLogged: checkForAccessToken,
        saveUser: saveUserData,
        removeUser: clearAuthenticationStorage,
        getHeaders: getHeaders,
        getUsername: getUsername
    }
}]);