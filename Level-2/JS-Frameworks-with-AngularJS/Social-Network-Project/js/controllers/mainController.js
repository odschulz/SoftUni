app.controller(
    'MainController',
    [
        '$scope',
        '$routeParams',
        'authentication',
        'DEFAULT_IMAGE',
        function ($scope, $routeParams, authentication, DEFAULT_IMAGE) {

            $scope.isLogged = function () {
                return authentication.isLogged();
            };

            $scope.me = {};
            $scope.me.username = authentication.getUsername();
            $scope.defaultImage = DEFAULT_IMAGE;
            $scope.isOwnWall = $scope.me.username === $routeParams['username'];
            $scope.relationshipWithUser = {};
            $scope.userPreviewData = {};

            $scope.openUserPreview = function (userPreviewData) {
                $scope.userPreviewData = userPreviewData;
                $scope.userPreviewShown = userPreviewData.username;
                console.log($scope.userPreviewShown);
                
            };

            $scope.closeUserPreview = function() {
                $scope.userPreviewShown = undefined;
            };


        }]);