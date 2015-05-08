var imdb = imdb || {};

(function (scope) {
    var uniqueId = 0;
    function Movie(title, length, rating, country) {
        uniqueId += 1;
        this._id = uniqueId;
        this.title = title;
        this.length = length;
        this.rating = rating;
        this.country = country;
        this._actors = [];
        this._reviews = [];
    }

    Movie.prototype.addActor = function addActor(actor) {
        this._actors.push(actor);
    };

    Movie.prototype.getActors = function getActors() {
        var actorsCopy = [];

        // return a copy of actors array so it cannot be modified
        for (var i = 0; i < this._actors.length; i += 1) {
            actorsCopy[i] = this._actors[i];
        }

        return actorsCopy;
    };

    Movie.prototype.addReview = function addReview(review) {
        this._reviews.push(review);
    };

    Movie.prototype.deleteReview = function deleteReview(review) {
        var index = this._reviews.indexOf(review);
        if (index > -1) {
            this._reviews.splice(index, 1);
        }
    };

    Movie.prototype.deleteReviewById  = function deleteReviewById(id) {
        var reviewToDelete, indexOfReviewToDelete = -1;

        for (var i = 0; i < this._reviews.length; i += 1) {
            if (this._reviews[i]._id === id) {
                indexOfReviewToDelete = i;
            }
        }

        if (indexOfReviewToDelete > -1) {
            this._reviews.splice(indexOfReviewToDelete, 1);
        }
    };

    Movie.prototype.getReviews = function getReviews() {
        var reviewsCopy = [];

        // return a copy of reviews array so it cannot be modified
        for (var i = 0; i < this._reviews.length; i += 1) {
            reviewsCopy[i] = this._reviews[i];
        }

        return reviewsCopy;
    };

    scope._Movie = Movie;

    scope.getMovie = function getMovie(title, length, rating, country) {
        return new Movie(title, length, rating, country);
    };

}(imdb));




