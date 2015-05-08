var imdb = imdb || {};

(function (scope) {
    function Theatre(name, length, rating, country) {
        imdb._Movie.apply(this, arguments);
        this.isPuppet = false;
    }

    Theatre.inherits(imdb._Movie);

    scope.getTheatre = function getTheatre(name, length, rating, country) {
        return new Theatre(name, length, rating, country);
    };

}(imdb));
