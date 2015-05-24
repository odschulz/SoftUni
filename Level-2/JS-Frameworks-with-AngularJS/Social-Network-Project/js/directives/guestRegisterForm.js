app.directive('guestRegisterForm', function () {
    return {
        controller: 'UserController',
        restrict: 'A',
        templateUrl: 'templates/directives/register-form.html',
        replace: true
    };
});