app.controller('UserController', ['$scope', 'authentication', 'Notification', 'userData', 'usSpinnerService', function ($scope, authentication, Notification, userData, usSpinnerService) {
    $scope.isLogged = function () {
        return authentication.isLogged();
    };

    $scope.login = function () {
        var user = $scope.user;

        usSpinnerService.spin('spinner-1');

        userData.login($scope.user)
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                authentication.saveUser(data);
            }, function (error) {
                Notification.error({message: error.data.error_description, delay: 2000});
            });
    };

    $scope.register = function () {
        var registerUserData = $scope.registerUserData;

        usSpinnerService.spin('spinner-1');

        userData.register(registerUserData)
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                authentication.saveUser(data);
            }, function (error) {
                Notification.error({message: error.data.error_description, delay: 2000});
            });
    };

    $scope.logout = function () {
        usSpinnerService.spin('spinner-1');

        userData.logout()
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                authentication.removeUser();
            }, function (error) {
                Notification.error({message: error.data.error_description, delay: 2000});
            });
    };
}]);
