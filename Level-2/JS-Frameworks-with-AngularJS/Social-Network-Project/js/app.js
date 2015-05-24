var app = angular.module('socialNetworkApp', ['ngResource', 'ngRoute', 'ngStorage', 'ui-notification']);

app.config(['$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'templates/home.html',
                controller: 'MainController'
            })
            .otherwise({
                redirectTo: '/'
            });
    }
]);

app.constant({
    'BASE_SERVICE_URL':'http://softuni-social-network.azurewebsites.net/api/'
});