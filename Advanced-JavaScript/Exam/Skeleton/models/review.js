var imdb = imdb || {};

(function (scope) {
    var uniqueId = 0;
    function Review(name, content, date) {
        uniqueId += 1;
        this._id = uniqueId;
        this.name = name;
        this.content = content;
        this.date = date;
    }

    scope.getReview = function getReview(name, content, date) {
        return new Review(name, content, date);
    };

}(imdb));