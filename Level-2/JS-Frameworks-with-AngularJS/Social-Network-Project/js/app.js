var app = angular.module('socialNetworkApp', ['ngResource', 'ngRoute', 'ngStorage', 'angularSpinner', 'ui-notification', 'infinite-scroll']);

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
            .when('/users/:username/', {
                templateUrl: 'templates/user-wall.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if (!$localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .when('/requests/', {
                templateUrl: 'templates/friend-requests.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if (!$localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .when('/users/:username/friends/', {
                templateUrl: 'templates/friends-list.html',
                controller: 'MainController',
                resolve: {
                    authorized: function ($localStorage, $location) {
                        if (!$localStorage.access_token) {
                            $location.path('/');
                        }
                    }
                }
            })
            .when('/profile/', {
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
            .when('/profile/password/', {
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
            .when('/not-found/', {
                templateUrl: 'templates/not-found.html',
                controller: 'MainController'
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
    'BASE_SERVICE_URL':'http://softuni-social-network.azurewebsites.net/api/',
    'FRIENDS_PREVIEW_COUNT': 6,
    'PAGE_SIZE': 5,
    'DEFAULT_IMAGE': 'data:image/png;base64,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'
});



