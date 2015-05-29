app.controller(
    'FriendController',
    [
        '$scope',
        '$location',
        '$timeout',
        'authentication',
        'Notification',
        'friendData',
        'userData',
        'usSpinnerService',
        'FRIENDS_PREVIEW_COUNT',
        function ($scope, $location, $timeout, authentication, Notification, friendData, userData, usSpinnerService, FRIENDS_PREVIEW_COUNT) {
            $scope.getMyFriendsPreviewData = function () {
                usSpinnerService.spin('spinner-1');

                friendData.getMyFriendsPreviewData(getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        var friendsPreviewData;
                        usSpinnerService.stop('spinner-1');

                        if (data.totalCount > 6) {
                            friendsPreviewData = data.friends.slice(0, 6);
                            console.log(friendsPreviewData);
                        } else {
                            friendsPreviewData = data.friends;
                        }

                        friendsPreviewData.totalCount = data.totalCount;
                        $scope.friendsPreviewData = friendsPreviewData;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retriece friends data!', delay: 4000});
                        console.log(error);
                    });
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }
        }]);
