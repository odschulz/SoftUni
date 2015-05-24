app.factory('userData', ['$resource', 'authentication', 'BASE_SERVICE_URL',function ($resource, authentication,BASE_SERVICE_URL) {

    function registerUser(user) {
        return $resource(BASE_SERVICE_URL + 'users/register')
            .save(user)
    }

    function loginUser(user) {
        return $resource(BASE_SERVICE_URL + 'users/login')
            .save(user);
    }

    function logoutUser() {

    }

    return {
        register: registerUser,
        login: loginUser,
        logout: logoutUser
    }
}]);
