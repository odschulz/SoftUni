app.controller(
    'UserController',
    [
        '$scope',
        '$location',
        '$timeout',
        'authentication',
        'Notification',
        'userData',
        'usSpinnerService',
        function ($scope, $location, $timeout, authentication, Notification, userData, usSpinnerService) {

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
                        Notification.success({message: 'Login successful!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Login unsuccessful!', delay: 4000});
                        console.log(error);
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
                        Notification.success({message: 'Registered successfully!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: error.data.message, delay: 4000});
                        console.log(error);
                    });
            };

            $scope.getMyProfilePreviewData = function () {
                var myUsername = authentication.getUsername();
                usSpinnerService.spin('spinner-1');

                userData.getUserPreviewData(getAuthenticationHeaders(), myUsername)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
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
                        Notification.success({message: 'Logout successful!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: error.data.message, delay: 4000});
                        console.log(error);
                    });
            };

            $scope.searchForUsers = function () {
                var searchPhrase = $scope.searchPhrase.trim();

                if(searchPhrase !== ""){
                    userData.searchForUsers(getAuthenticationHeaders(), searchPhrase)
                        .$promise
                        .then(function (data) {
                            $scope.searchResults = data;

                        }, function (error) {
                            Notification.error({message: 'Could not retrieve data from server!', delay: 4000});
                        });
                } else {
                    $scope.searchResults = undefined;
                }
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }

            $scope.clearSearchResults = function () {
                $timeout(function() {
                    $scope.searchResults = undefined;
                    $scope.searchPhrase = '';
                }, 500);
            };

        }]);
