app.controller('UserController', ['$scope', '$location','authentication', 'Notification', 'userData', 'usSpinnerService', function ($scope, $location, authentication, Notification, userData, usSpinnerService) {
    $scope.isLogged = function () {
        return authentication.isLogged();
    };

    $scope.login = function () {
        var user = $scope.user;

        usSpinnerService.spin('spinner-1');

        userData.login(user)
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                authentication.saveUser(data);
                $location.path('/');
            }, function (error) {
                usSpinnerService.stop('spinner-1');
                Notification.error({message: error.data.error_description, delay: 4000});
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
                $location.path('/');
            }, function (error) {
                usSpinnerService.stop('spinner-1');
                Notification.error({message: error.data.message, delay: 4000});
            });
    };

    $scope.getMyProfilePreviewData = function () {
        var myUsername = authentication.getUsername();
        usSpinnerService.spin('spinner-1');

        userData.getUserPreviewData(getAuthenticationHeaders(), myUsername)
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                $scope.me = {} || $scope.me;
                $scope.me.fullName = data.name;
                $scope.me.profileImage = data.profileImageData;
            }, function (error) {
                usSpinnerService.stop('spinner-1');
                Notification.error({message: 'Could not retrieve your profile data from the server!', delay: 4000});
            });
    };

    $scope.logout = function () {
        usSpinnerService.spin('spinner-1');

        userData.logout(getAuthenticationHeaders())
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                authentication.removeUser();
            }, function (error) {
                usSpinnerService.stop('spinner-1');
                Notification.error({message: error.data.message, delay: 4000});
            });
    };

    function getAuthenticationHeaders() {
        return authentication.getHeaders();
    }

    $scope.test = function () {
        console.log('test');
        console.log($scope);
        console.log($scope.$scope);

    }

}]);
