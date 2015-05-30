app.controller(
    'PostsController',
    [
        '$scope',
        '$location',
        '$timeout',
        '$route',
        'authentication',
        'Notification',
        'PAGE_SIZE',
        'postsData',
        'userData',
        'usSpinnerService',
        function ($scope, $location, $timeout, $route, authentication, Notification, PAGE_SIZE, postsData, userData, usSpinnerService) {

            var startPostId = '';
            $scope.commentsViews = [];
            $scope.posts = [    ];

            $scope.getNewsFeed = function () {
                usSpinnerService.spin('spinner-1');

                postsData.getNewsFeed(getAuthenticationHeaders(), startPostId, PAGE_SIZE)
                    .$promise
                    .then(function (data) {
                        $scope.posts = $scope.posts.concat(data);
                        if($scope.posts.length > 0){
                            startPostId = $scope.posts[$scope.posts.length - 1].id;
                        }

                        usSpinnerService.stop('spinner-1');
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not retrieve news feed!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.newComment = {};

            $scope.addCommentToPost = function (post) {
                var newComment = {};
                newComment.commentContent = $scope.newComment[post.id];

                if (newComment.commentContent) {
                    if (newComment.commentContent.length < 2) {
                        Notification.error({message: 'Comment must be at least 2 symbols!', delay: 4000});
                        return;
                    }

                    usSpinnerService.spin('spinner-1');

                    postsData.addCommentToPost(getAuthenticationHeaders(), post.id, newComment)
                        .$promise
                        .then(function (data) {
                            usSpinnerService.stop('spinner-1');

                            // push new comment in post comments data
                            post.comments.unshift(data);
                            // clear the text area for the comment input
                            $scope.newComment[post.id] = undefined;
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

            $scope.getPostComments = function (post) {
                usSpinnerService.spin('spinner-1');
                postsData.getPostComments(getAuthenticationHeaders(), post.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        post.comments = data;

                        $scope.commentsViews.push(post.id);

                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not get all comment for post!', delay: 4000});
                        console.log(error);
                    });

            };


            $scope.getPostCommentsPreview = function (post) {
                var index = $scope.commentsViews.indexOf(post.id);

                post.comments = post.comments.slice(0, 3);
                if (index > -1) {
                    $scope.commentsViews.splice(index, 1);
                }

            };

            $scope.likePost = function (post) {

                postsData.likePost(getAuthenticationHeaders(), post.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        post.liked = true;
                        post.likesCount ++;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not like post!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.unlikePost = function (post) {
                postsData.unLikePost(getAuthenticationHeaders(), post.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        post.liked = false;
                        post.likesCount --;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not unlike post!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.likeComment = function (post, comment) {

                postsData.likeComment(getAuthenticationHeaders(), post.id, comment.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        comment.liked = true;
                        comment.likesCount ++;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not like post!', delay: 4000});
                        console.log(error);
                    });
            };

            $scope.unlikeComment = function (post, comment) {
                postsData.unlikeComment(getAuthenticationHeaders(), post.id, comment.id)
                    .$promise
                    .then(function (data) {
                        usSpinnerService.stop('spinner-1');

                        comment.liked = false;
                        comment.likesCount --;
                    }, function (error) {
                        usSpinnerService.stop('spinner-1');
                        Notification.error({message: 'Could not unlike post!', delay: 4000});
                        console.log(error);
                    });
            };

            function getAuthenticationHeaders() {
                return authentication.getHeaders();
            }

        }]);

