app.directive('newsFeed', function () {
    return {
        restrict: 'A',
        controller: 'PostsController',
        templateUrl: 'templates/directives/news-feed.html',
        replace: false
    };
});
