app.directive('userNavigationHeader', function () {
    return {
        controller: 'UserController',
        restrict: 'A',
        templateUrl: 'templates/directives/navigation-header.html',
        replace: true
    };
});