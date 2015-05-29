app.controller('MainController', ['$scope', 'authentication', 'DEFAULT_IMAGE', function ($scope, authentication, DEFAULT_IMAGE) {
    $scope.isLogged = function () {
        return authentication.isLogged();
    };
    
    $scope.me = {};
    $scope.me.username = authentication.getUsername();
    $scope.defaultImage = DEFAULT_IMAGE;


}]);