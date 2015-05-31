app.directive('friendStatusButtons', function () {
    return {
        restrict: 'A',
        templateUrl: 'templates/directives/friend-status-buttons.html',
        controller: 'FriendController',
        replace: true
    };
});