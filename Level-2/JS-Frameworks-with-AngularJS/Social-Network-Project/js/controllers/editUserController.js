app.controller('EditUserController', ['$scope', '$location', 'authentication', 'userData', 'Notification', 'usSpinnerService', function ($scope, $location, authentication, userData, Notification, usSpinnerService) {
    $scope.changePassword = function (data) {
        var passwordData = $scope.passwordData;
        console.log(passwordData);
        

        usSpinnerService.spin('spinner-1');

        userData.changePassword(passwordData)
            .$promise
            .then(function (data) {
                usSpinnerService.stop('spinner-1');
                $location.path('/');
            }, function (error) {
                usSpinnerService.stop('spinner-1');
                Notification.error({message: error.data.message, delay: 2000});
            });
    }

}]);