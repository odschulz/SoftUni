app.factory('authentication', ['$localStorage', function($localStorage){

    function checkForAccessToken() {
        return $localStorage.access_token !== undefined;
    }

    function saveUserAccessToken(data) {
        // TODO: see if needed to separate save user and save token
        $localStorage.$default({
            access_token: data.access_token,
            token_type: data.token_type,
            username: data.userName
        });
        console.log($localStorage);

    }
    function clearAuthenticationStorage() {
        $localStorage.$reset();
    }

    return {
        isLogged: checkForAccessToken,
        saveUser: saveUserAccessToken,
        deleteAuthentication: clearAuthenticationStorage
    }
}]);