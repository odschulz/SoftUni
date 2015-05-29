var app = angular.module('socialNetworkApp', ['ngResource', 'ngRoute', 'ngStorage', 'angularSpinner', 'ui-notification']);

app.config(['$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'templates/home.html',
                controller: 'MainController'
            })
            .when('/login/', {
                templateUrl: 'templates/login-form.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if ($localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .when('/register', {
                templateUrl: 'templates/register-form.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if ($localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .when('/settings/edit/profile/', {
                templateUrl: 'templates/edit-profile-form.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if (!$localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .when('/settings/edit/password/', {
                templateUrl: 'templates/edit-password-form.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if (!$localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .otherwise({
                redirectTo: '/'
            });
    }
]);

app.config(['$httpProvider',function($httpProvider) {
    //Http Interceptor to check auth failures
    $httpProvider.interceptors.push('authHttpResponseInterceptor');
}]);

app.config(['usSpinnerConfigProvider', function (usSpinnerConfigProvider) {
    usSpinnerConfigProvider.setDefaults({
        lines: 7, // The number of lines to draw
        length: 1, // The length of each line
        width: 21, // The line thickness
        radius: 23, // The radius of the inner circle
        corners: 0.6, // Corner roundness (0..1)
        rotate: 90, // The rotation offset
        color: '#66AFE9', // #rgb or #rrggbb or array of colors
        speed: 0.5, // Rounds per second
        trail: 50 // Afterglow percentage
    });
}]);

app.constant({
    'BASE_SERVICE_URL':'http://softuni-social-network.azurewebsites.net/api/'
});