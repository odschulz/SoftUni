var imdb = imdb || {};

(function (scope) {
    var uniqueId = 0;
    function Actor(name, bio, born) {
        uniqueId += 1;
        this._id = uniqueId;
        this.name = name;
        this.bio = bio;
        this.born = born;
    }

    scope.getActor = function getActor(name, bio, born) {
        return new Actor(name, bio, born);
    };

}(imdb));