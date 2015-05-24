
app.controller('VideoDetailsController', function ($scope, $routeParams, videosService) {
    var videoTitle = $routeParams.title;
    $scope.video = videosService.getVideoDetails(videoTitle);
    console.log($scope.videoDetails);
});