app.controller('UserController', ['$scope', 'authentication', 'Notification', 'userData', function ($scope, authentication, Notification, userData) {
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
                Notification.error({message: error.data.error_description, delay: 2000});
            });
    };

    $scope.register = function () {
        var registerUserData = $scope.registerUserData;

        userData.register(registerUserData)
            .$promise
            .then(function (data) {
                authentication.saveUser(data);
            }, function (error) {
                Notification.error({message: error.data.error_description, delay: 2000});
            });
    };

    $scope.logout = function () {
        userData.logout()
            .$promise
            .then(function (data) {
                authentication.removeUser();
            }, function (error) {
                Notification.error({message: error.data.error_description, delay: 2000});
            });
    };
}]);
