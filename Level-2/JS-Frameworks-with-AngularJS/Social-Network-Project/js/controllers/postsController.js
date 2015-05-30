app.controller(
    'PostsController',
    [
        '$scope',
        '$location',
        '$timeout',
        'authentication',
        'Notification',
        'postsData',
        'userData',
        'usSpinnerService',
        function ($scope, $location, $timeout, authentication, Notification, postsData, userData, usSpinnerService) {

            $scope.getNewsFeed = function () {
                usSpinnerService.spin('spinner-1');

                postsData.getNewsFeed(getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $scope.posts = data;
                        console.log(data);

                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve news feed!', delay: 4000});
                        console.log(error);
                    });
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }
        }]);

