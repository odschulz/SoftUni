app.directive('userWallCommentBox', function () {
    return {
        controller: 'PostsController',
        restrict: 'A',
        templateUrl: 'templates/directives/user-wall-comment-box.html',
        replace: false
    };
});
