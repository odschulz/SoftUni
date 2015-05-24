app.controller('VideosController', function ($scope, videosService) {
    $scope.videos = videosService.getVideos();

    $scope.categoryOptions = [
        {
            "id": 0,
            "title": "All"
        },
        {
            "id": 1,
            "title": "IT"
        },
        {
            "id": 2,
            "title": "Music"
        },
        {
            "id": 3,
            "title": "Other"
        }
    ];

    $scope.ascendingOrDescendingOptions = [
        { text: "Ascending", bool: false },
        { text: "Descending", bool: true }
    ];

    $scope.categoryFilter = function (data) {
        var selectedCategory = $scope.categoryOptions[$scope.selectedCategory].title;

        if (data.category === selectedCategory ||
            selectedCategory === 'All') {
            return true;
        } else {
            return false;
        }
    };

    $scope.dateFilter = function (data) {
        var selectedDate = $scope.selectedDate,
            videoDate = data.date;

        if (selectedDate === undefined ||
            selectedDate.toLocaleDateString() == videoDate.toLocaleDateString()) {
            return true;
        }

        return false;
    };

    $scope.subtitledFilter = function (data) {

        if ($scope.selectedSubtitled) {
            return data.haveSubtitles;
        }

        return true;
    };

});