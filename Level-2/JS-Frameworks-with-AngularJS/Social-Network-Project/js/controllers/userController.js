app.controller('UserController', ['$scope', 'authentication','userData',function ($scope, authentication, userData) {
    $scope.isLogged = function () {
        return authentication.isLogged();
    };

    $scope.login = function () {
        var user = $scope.user;

        userData.login($scope.user)
            .$promise
            .then(function (data) {
                authentication.saveUser(data);
            }, function (error) {
                // TODO: Get Noty or something
                console.log(error.data.error_description);
            });
    };

    $scope.register = function () {
        var registerUserData = $scope.registerUserData;

        userData.register(registerUserData)
            .$promise
            .then(function (data) {
                authentication.saveUser(data);
            }, function (error) {
                // TODO: Get Noty or something
                console.log(error.data.error_description);
            });
    };

    $scope.logout = function () {

    };

}]);
