app.directive('friendsPreview', function () {
    return {
        restrict: 'A',
        templateUrl: 'templates/directives/friends-preview.html',
        controller: 'FriendController',
        replace: false
    };
});