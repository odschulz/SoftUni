//source: http://blog.thesparktree.com/post/75952317665/angularjs-interceptors-globally-handle-401-and

app.factory('authHttpResponseInterceptor',['$q','$location', '$localStorage', function($q, $location, $localStorage){
    return {
        response: function(response){
            if (response.status === 401) {
                $location.path('/');
            }
            return response || $q.when(response);
        },
        responseError: function(rejection) {
            if (rejection.status === 401) {
                $localStorage.$reset();
                $location.path('/');
            } else if(rejection.status === 404){
                $location.path('/not-found');
            }
            return $q.reject(rejection);
        }
    };
}]);