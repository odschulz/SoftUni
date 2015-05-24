var models = models || {};

models.video = (function() {
    function Video(data) {
        this.title = data.title;
        this.pictureUrl = data.pictureUrl;
        this.length = data.length || 0;
        this.category = data.category;
        this.subscribers = 0;
        this. date = new Date(Date.now());
        this.haveSubtitles = data.haveSubtitles;
        this.comments = [];
    }

    Headers.prototype.getVideoDetails = function () {
        for (var item in this) {
            console.log(item);

        }
    };

    return {
        load : function (data) {
            return new Video(data);
        }
    }
}());
