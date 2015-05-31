app.controller(
    'FriendController',
    [
        '$scope',
        '$location',
        '$timeout',
        '$interval',
        '$routeParams',
        'authentication',
        'Notification',
        'friendData',
        'userData',
        'usSpinnerService',
        'FRIENDS_PREVIEW_COUNT',
        function ($scope, $location, $timeout, $interval, $routeParams, authentication, Notification, friendData, userData, usSpinnerService, FRIENDS_PREVIEW_COUNT) {

            $scope.pendingRequests = [];
            $scope.currentUser = $routeParams['username'];

            $scope.getFriendRequests = function () {
                friendData.getFriendRequests(getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $scope.pendingRequests = data;

                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve requests data!', delay: 4000});
                        console.log(error);
                    });
            };

            var interval = $interval($scope.getFriendRequests, 20000);

            $scope.$on('$destroy', function () { $interval.cancel(interval); });

            $scope.getMyFriendsPreviewData = function () {
                $scope.currentUser = $scope.currentUser || $scope.me.username;
                usSpinnerService.spin('spinner-1');
                $scope.friendsOwner = $routeParams['username'];

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

            $scope.getGetFriendsOfFriendPreviewData = function () {
                var username = $routeParams['username'];

                usSpinnerService.spin('spinner-1');

                friendData.getGetFriendsOfFriendPreviewData(getAuthenticationHeaders(), username)
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

            $scope.getFriendsOfFriendDetailedList = function () {
                var username = $routeParams['username'];
                friendData.getFriendsOfFriendDetailedList(getAuthenticationHeaders(), username)
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
                        $scope.relationshipWithUser.hasPendingRequest = true;
                        Notification.success({message: 'Friend request successfully sent!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not send friend request!', delay: 4000});
                        console.log(error);
                    });

                
            };

            $scope.approveFriendRequest = function (request) {
                friendData.approveFriendRequest(getAuthenticationHeaders(), request.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $scope.getFriendRequests();
                        Notification.success({message: 'Friend request successfully approved!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not approve friend request!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.rejectFriendRequest = function (request) {
                friendData.rejectFriendRequest(getAuthenticationHeaders(), request.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $scope.getFriendRequests();
                        Notification.success({message: 'Friend request successfully rejected!', delay: 4000});
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not reject friend request!', delay: 4000});
                        console.log(error);
                    });
            };


            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }
        }]);
