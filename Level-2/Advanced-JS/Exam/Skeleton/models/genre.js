var imdb = imdb || {};

(function (scope) {
    var uniqueId = 0;
    function Genre(name) {
        uniqueId += 1;
        this._id = uniqueId;
        this.name = name;
        this._movies = [];
    }

    Genre.prototype.addMovie = function addMovie(movie) {
        this._movies.push(movie);
    };

    Genre.prototype.deleteMovie = function deleteMovie(movie) {
        var index = this._movies.indexOf(movie);
        if (index > -1) {
            this._movies.splice(index, 1);
        }
    };

    Genre.prototype.deleteMovieById = function deleteMovieById(id) {
        var movieToDelete, indexOfMovieToDelete = -1;

        for (var i = 0; i < this._movies.length; i += 1) {
            if (this._movies[i]._id === id) {
                indexOfMovieToDelete = i;
            }
        }

        if (indexOfMovieToDelete > -1) {
            this._movies.splice(indexOfMovieToDelete, 1);
        }
    };

    Genre.prototype.getMovies = function getMovies() {
        var moviesCopy = [];

        // return a copy of movies array so it cannot be modified
        for (var i = 0; i < this._movies.length; i += 1) {
            moviesCopy[i] = this._movies[i];
        }

        return moviesCopy;
    };

    scope.getGenre = function getGenre(name) {
        return new Genre(name);
    };

}(imdb));