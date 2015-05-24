app.factory('authentication', ['$localStorage', function($localStorage){

    function checkForAccessToken() {
        return $localStorage.access_token !== undefined;
    }

    function saveUserData(data) {
        // TODO: see if needed to separate save user and save token
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

    function getUserData() {
        return $localStorage;
    }

    return {
        isLogged: checkForAccessToken,
        saveUser: saveUserData,
        removeUser: clearAuthenticationStorage,
        getHeaders: getHeaders
    }
}]);