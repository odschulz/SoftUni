app.controller(
    'UserWallController',
    [
        '$scope',
        '$location',
        '$routeParams',
        'authentication',
        'Notification',
        'userData',
        'usSpinnerService',
        function ($scope, $location, $routeParams, authentication, Notification, userData, usSpinnerService) {
            $scope.getWallOwnerData = function () {
                usSpinnerService.spin('spinner-1');
                var wallOwnerUsername = $routeParams['username'];
                userData.getUserFullData(getAuthenticationHeaders(), wallOwnerUsername)
                    .$promise
                    .then(function (data) {
                        $scope.wallOwner = data;
                        $scope.relationshipWithUser.isFriend = data.isFriend;
                        $scope.relationshipWithUser.hasPendingRequest = data.hasPendingRequest;

                        if (wallOwnerUsername === $scope.me.username) {
                            $scope.wallOwner.isMe = true;
                        } else {
                            $scope.wallOwner.isMe = false;
                        }

                        if (!$scope.wallOwner.isMe) {
                            $scope.relationshipWithUser.isNotFriend = !$scope.wallOwner.hasPendingRequest && !$scope.wallOwner.isFriend ;
                        }


                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: error.data.message, delay: 4000});
                        console.log(error);
                    });
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }

        }]);
