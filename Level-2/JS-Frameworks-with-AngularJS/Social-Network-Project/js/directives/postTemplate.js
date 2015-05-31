app.directive('postTemplate', function () {
    return {
        restrict: 'A',
        templateUrl: 'templates/directives/post.html',
        replace: true
    };
});
