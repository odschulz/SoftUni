var app = angular.module('videoSystem', ['ngRoute']);

app.config(['$routeProvider',
    function($routeProvider) {
        $routeProvider.
            when('/videos', {
                templateUrl: 'partials/videos.html',
                controller: 'VideosController'
            }).
            when('/videos/:title', {
                templateUrl: 'partials/video-details.html',
                controller: 'VideoDetailsController'
            }).
            when('/add-video', {
                templateUrl: 'partials/add-video.html',
                controller: 'AddVideoController'
            }).
            otherwise({
                redirectTo: '/videos'
            });
    }
]);