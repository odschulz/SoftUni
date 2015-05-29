app.controller(
    'EditUserController',
    [
        '$scope',
        '$location',
        'authentication',
        'userData',
        'Notification',
        'usSpinnerService',
        function ($scope, $location, authentication, userData, Notification, usSpinnerService) {

            $scope.changePassword = function (data) {
                var passwordData = $scope.passwordData;

                usSpinnerService.spin('spinner-1');

                userData.changePassword(passwordData, getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $location.path('/');
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: error.data.message, delay: 4000});
                    });
            };

            $scope.getUserData = function () {
                usSpinnerService.spin('spinner-1');

                userData.getDataAboutMe(getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $scope.userData = data;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve your personal data from the server', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.editProfile = function () {

                var newProfileData = $scope.userData;

                usSpinnerService.spin('spinner-1');

                userData.editProfile(newProfileData, getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $location.path('/');
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not upload your updated profile data to the server', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.refreshEditProfilePage = function () {
                this.getUserData()
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }

            $scope.putImageInUserData = function(input) {
                if (input.files && input.files[0]) {
                    var reader = new FileReader();
                    var inputButtonId = $(input).attr('id');
                    var imageContainerId = getImageContainerId(inputButtonId);
                    var propertyName = getPropertyName(imageContainerId);

                    reader.onload = function (e) {
                        $('#' + imageContainerId).attr('src', e.target.result);
                        $scope.userData[propertyName] = e.target.result;
                    };

                    reader.readAsDataURL(input.files[0]);
                }

                function getImageContainerId(inputButtonId) {
                    var words = inputButtonId.split('-');
                    var imageContainerId = words[0] + '-' + words[1];

                    return imageContainerId;
                }

                function getPropertyName(elementId) {
                    var words = elementId.split('-');
                    var propertyName = words[0].toLowerCase() + words[1].capitalizeFirstLetter() + 'Data';

                    return propertyName;
                }
            };
        }]);