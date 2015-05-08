app.controller('StudentController', function ($scope) {

    var students = [
        {
            "name": "Pesho",
            "photo": "http://wallpaper.ultradownloads.com.br/276158_Papel-de-Parede-Meme-Trollface_800x600.jpg",
            "grade": 42,
            "school": "High School of Mathematics",
            "teacher": "Gichka Pesheva"
        },
        {
            "name": "Freddie",
            "photo": "http://wallpaperscraft.com/image/101748/800x600.jpg",
            "grade": 'N/A',
            "school": "High School of Arts",
            "teacher": "God"
        }
    ];
    $scope.students = students;
    $scope.demo = 'demo message';
    console.log($scope.name);


});
