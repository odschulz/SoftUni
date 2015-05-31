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
                        } else {
                            friendsPreviewData = data.friends;
                        }

                        friendsPreviewData.totalCount = data.totalCount;
                        $scope.friendsPreviewData = friendsPreviewData;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve friends data!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.getMyFriendsList = function () {
                friendData.getMyFriendsList(getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        $scope.friendsData = data;
                        $scope.friendsData.totalCount = data.length;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve friends data!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.sendFriendRequest = function (username) {
                friendData.sendFriendRequest(getAuthenticationHeaders(), username)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        Notification.success({message: 'Friend request successfully sent!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve friends data!', delay: 4000});
                        console.log(error);
                    });

                
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }
        }]);
