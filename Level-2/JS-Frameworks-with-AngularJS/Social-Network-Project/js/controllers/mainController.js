app.controller('MainController', ['$scope', 'authentication', function ($scope, authentication) {
    $scope.isLogged = function () {
        return authentication.isLogged();
    };

}]);