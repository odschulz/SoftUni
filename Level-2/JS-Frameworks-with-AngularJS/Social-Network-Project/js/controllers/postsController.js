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

            $scope.commentsViews = [];

            $scope.getNewsFeed = function () {
                usSpinnerService.spin('spinner-1');

                postsData.getNewsFeed(getAuthenticationHeaders())
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');
                        $scope.posts = data;

                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve news feed!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.newComment = {};

            $scope.addCommentToPost = function (postId) {
                var newComment = {};
                newComment.commentContent = $scope.newComment[postId];

                if (newComment.commentContent) {
                    if (newComment.commentContent.length < 2) {
                        Notification.error({message: 'Comment must be at least 2 symbols!', delay: 4000});
                        return;
                    }

                    usSpinnerService.spin('spinner-1');

                    postsData.addCommentToPost(getAuthenticationHeaders(), postId, newComment)
                        .$promise
                        .then(function (data) {
                            usSpinnerService.stop('spinner-1');

                            var post = $scope.posts.filter(function (post) {
                                return post.id == postId;
                            })[0];

                            // push new comment in post comments data
                            post.comments.unshift(data);
                            // clear the text area for the comment input
                            $scope.newComment[postId] = undefined;
                            // increase total comments amount in post
                            post.totalCommentsCount ++;

                        }, function (error) {
                            usSpinnerService.stop('spinner-1');
                            Notification.error({message: 'Could not add comment!', delay: 4000});
                            console.log(error);
                        });




                } else {
                    Notification.error({message: 'Cannot add an empty comment!', delay: 4000});
                }
            };

            $scope.getPostComments = function (postId) {
                usSpinnerService.spin('spinner-1');
                postsData.getPostComments(getAuthenticationHeaders(), postId)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        var post = $scope.posts.filter(function (post) {
                            return post.id == postId;
                        })[0];

                        post.comments = data;

                        $scope.commentsViews.push(postId);

                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not add comment!', delay: 4000});
                        console.log(error);
                    });

            };


            $scope.getPostCommentsPreview = function (postId) {
                var index = $scope.commentsViews.indexOf(postId);
                var post = $scope.posts.filter(function (post) {
                    return post.id == postId;
                })[0];

                post.comments = post.comments.slice(0, 3);
                if (index > -1) {
                    $scope.commentsViews.splice(index, 1);
                }

            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }

        }]);

