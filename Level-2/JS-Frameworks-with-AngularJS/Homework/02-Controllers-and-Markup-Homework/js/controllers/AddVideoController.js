app.controller('AddVideoController', function ($scope, videosService) {
    console.log($scope);
    
    $scope.addNewVideo = function () {
        var newVideoData = $scope.newVideo;
        var newVideo = models.video.load(newVideoData);

        videosService.addVideo(newVideo);

        window.location.replace('#/videos');
    }
});