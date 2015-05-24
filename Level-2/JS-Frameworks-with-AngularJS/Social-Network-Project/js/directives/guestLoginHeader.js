app.directive('guestLoginHeader', function () {
    return {
        controller: 'UserController',
        restrict: 'A',
        templateUrl: 'templates/directives/login-header.html',
        replace: true
    };
});