app.directive('userHeader', function () {
    return {
        controller: 'UserController',
        restrict: 'A',
        templateUrl: 'templates/directives/user-header.html',
        replace: false
    };
});