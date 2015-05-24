app.service('videosService', function () {
    this.getVideos = function () {
        return videos;
    };

    this.addVideo = function (video) {
        videos.push(video);
    };

    this.getVideoDetails = function (videoTitle) {
        var result = videos.filter(function (video) {
            return video.title === videoTitle
        })[0];

        return result;
    };

   var videos = [
       {
           title: 'Intro to Programming',
           pictureUrl: 'http://www.nakov.com/wp-content/uploads/photos/Nakov-face.jpg',
           length: '55:10',
           category: 'IT',
           subscribers: 10,
           date: new Date(2015, 4, 11),
           haveSubtitles: true,
           comments: [
               {
                   username: 'Mincho',
                   content: 'Congratulations Nakov',
                   date: new Date(2014, 12, 15, 12, 30, 0),
                   likes: 3,
                   websiteUrl: 'http://mincho.com/'
               },
               {
                   username: 'Pesho Peshev',
                   content: 'Evala bate, golema glava imash!',
                   date: new Date(2015, 12, 15, 12, 30, 0),
                   likes: 8,
                   websiteUrl: 'http://pesho.com/'
               }
           ]
       },
       {
           title: 'Queen - Don\'t Stop Me Now (Official Video)',
           pictureUrl: 'http://wallpaper.ultradownloads.com.br/276166_Papel-de-Parede-Meme-Freddie-Mercury_800x600.jpg',
           length: '3:38',
           category: 'Music',
           subscribers: 1000,
           date: new Date(2013, 12, 15),
           haveSubtitles: false,
           comments: [
               {
                   username: 'John Doe',
                   content: 'Awesome',
                   date: new Date(2014, 12, 15, 12, 30, 0),
                   likes: 3,
                   websiteUrl: 'http://john.com/'
               }
           ]
       },
       {
           title: 'Slayer - Raining Blood',
           pictureUrl: 'http://www.bestrockpics.com/data/media/128/Slayer%20wallpaper%20(4).jpg',
           length: '2:28',
           category: 'Music',
           subscribers: 800,
           date: new Date(2010, 12, 15),
           haveSubtitles: true,
           comments: [
               {
                   username: 'Satanist',
                   content: 'All hail the Dark One',
                   date: new Date(2013, 12, 15, 12, 30, 0),
                   likes: 2,
                   websiteUrl: 'http://darkness.com/'
               }
           ]
       }
   ];
});
