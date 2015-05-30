app.controller(
    'PostsController',
    [
        '$scope',
        '$location',
        '$timeout',
        '$route',
        'authentication',
        'Notification',
        'postsData',
        'userData',
        'usSpinnerService',
        function ($scope, $location, $timeout, $route, authentication, Notification, postsData, userData, usSpinnerService) {

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

            $scope.newComment = {
                commentContent: undefined
            };

            $scope.addCommentToPost = function (postId) {
                var newComment = $scope.newComment;

                if (newComment.commentContent) {
                    if (newComment.commentContent.length < 2) {
                        Notification.error({message: 'Comment must be at least 2 symbols!', delay: 4000});
                        return;
                    }

                    usSpinnerService.spin('spinner-1');

                    postsData.addCommentToPost(getAuthenticationHeaders(), postId, newComment)
                        .$promise
                        .then(function (data) {
                            console.log(data);

                            usSpinnerService.stop('spinner-1');
                            var post = $scope.posts.filter(function (post) {
                                return post.id == postId;
                            })[0];

                            post.comments.unshift(data);

                        }, function (error) {
                            usSpinnerService.stop('spinner-1');
                            Notification.error({message: 'Could not add comment!', delay: 4000});
                            console.log(error);
                        });




                } else {
                    Notification.error({message: 'Cannot add an empty comment!', delay: 4000});
                }


                //postsData.addCommentToPost(getAuthenticationHeaders())
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }
        }]);

