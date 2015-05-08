var imdb = imdb || {};

(function (scope) {
	function loadHtml(selector, data) {
		var container = document.querySelector(selector),
			moviesContainer = document.getElementById('movies'),
			detailsContainer = document.getElementById('details'),
			genresUl = loadGenres(data);

		container.appendChild(genresUl);

		genresUl.addEventListener('click', function (ev) {
			if (ev.target.tagName === 'LI') {
				var genreId,
					genre,
					moviesHtml;

				genreId = parseInt(ev.target.getAttribute('data-id'));
				genre = data.filter(function (genre) {
					return genre._id === genreId;
				})[0];

				moviesHtml = loadMovies(genre.getMovies());
				moviesContainer.innerHTML = moviesHtml.outerHTML;
				moviesContainer.setAttribute('data-genre-id', genreId.toString());
			}
		});

		// Task 2 - Add event listener for movies boxes

        moviesContainer.addEventListener('click', function (ev) {
            if (ev.target.tagName === 'LI') {
                var movieId,
                    movie,
                    movieDetailsHtml,
                    movies,
                    genre,
                    genreId;

                movieId = parseInt(ev.target.getAttribute('data-id'));
                genreId = parseInt(moviesContainer.getAttribute('data-genre-id'));
                genre = data.filter(function (genre) {
                    return genre._id === genreId;
                })[0];

                movies = genre.getMovies();

                movie = movies.filter(function (movie) {
                    return movie._id === movieId;
                })[0];

                movieDetailsHtml = loadMovieDetails(movie.getActors(), movie.getReviews());
                detailsContainer.innerHTML = movieDetailsHtml.outerHTML;
                detailsContainer.setAttribute('data-movie-id', movieId.toString());
            }
        });

		// Task 3 - Add event listener for delete button (delete movie button or delete review button)

        moviesContainer.addEventListener('click', function (ev) {
            if (ev.target.tagName === 'BUTTON') {
                var movieId = parseInt(ev.target.parentNode.getAttribute('data-id')),
                    movieContainer = ev.target.parentNode,
                    genreId = parseInt(movieContainer.parentNode.parentNode.getAttribute('data-genre-id')),
                    detailsContainer = document.querySelector("#details");

                deleteMovieFromGenre(genreId);
                deleteMovieFromDom(movieContainer);
                updateDetailsContainer(detailsContainer, movieId);

                function deleteMovieFromGenre(genreId) {
                    var genre = data.filter(function (genre) {
                        return genre._id  === genreId;
                    })[0];

                    genre.deleteMovieById(movieId);
                }

                function deleteMovieFromDom(nodeToRemove) {
                    nodeToRemove.parentNode.removeChild(nodeToRemove);
                }

                function updateDetailsContainer(detailsNode, removedElementId) {
                    if (detailsNode.getAttribute('data-movie-id') == removedElementId) {
                        detailsNode.innerHTML = '';
                        detailsNode.removeAttribute('data-movie-id');
                    }
                }
            }
        });
	}

	function loadGenres(genres) {
		var genresUl = document.createElement('ul');
		genresUl.setAttribute('class', 'nav navbar-nav');
		genres.forEach(function (genre) {
			var liGenre = document.createElement('li');
			liGenre.innerHTML = genre.name;
			liGenre.setAttribute('data-id', genre._id);
			genresUl.appendChild(liGenre);
		});

		return genresUl;
	}

	function loadMovies(movies) {
		var moviesUl = document.createElement('ul');
		movies.forEach(function (movie) {
			var liMovie = document.createElement('li');
			liMovie.setAttribute('data-id', movie._id);

			liMovie.innerHTML = '<h3>' + movie.title + '</h3>';
			liMovie.innerHTML += '<div>Country: ' + movie.country + '</div>';
			liMovie.innerHTML += '<div>Time: ' + movie.length + '</div>';
			liMovie.innerHTML += '<div>Rating: ' + movie.rating + '</div>';
			liMovie.innerHTML += '<div>Actors: ' + movie._actors.length + '</div>';
			liMovie.innerHTML += '<div>Reviews: ' + movie._reviews.length + '</div>';
            liMovie.innerHTML += '<button>Delete movie</button>';
			
			moviesUl.appendChild(liMovie);
		});

		return moviesUl;
	}

    function loadMovieDetails(actors, reviews) {
        var detailsUl = document.createElement('ul'),
            actorsContainer = document.createElement('li'),
            reviewsContainer = document.createElement('li'),
            actorsHeader = document.createElement('h2'),
            reviewsHeader = document.createElement('h2'),
            actorsUl = document.createElement('ul'),
            reviewsUl = document.createElement('ul');

        actorsHeader.innerText = 'Actors';
        actorsContainer.appendChild(actorsHeader);
        reviewsHeader.innerText = 'Reviews';
        reviewsContainer.appendChild(reviewsHeader);

        actors.forEach(function (actor) {
            var liActor = document.createElement('li');
            liActor.setAttribute('data-id', actor._id);

            liActor.innerHTML += '<h3>' + actor.name + '</h3>';
            liActor.innerHTML += '<p><b>Bio:</b> ' + actor.bio + '</p>';
            liActor.innerHTML += '<p><b>Born:</b> ' + actor.born + '</p>';

            actorsUl.appendChild(liActor);
        });

        reviews.forEach(function (review) {
            var liReview = document.createElement('li');
            liReview.setAttribute('data-id', review._id);

            liReview.innerHTML += '<h3>' + review.name + '</h3>';
            liReview.innerHTML += '<p><b>Content:</b> ' + review.content + '</p>';
            liReview.innerHTML += '<p><b>Date:</b> ' + review.date + '</p>';


            reviewsUl.appendChild(liReview);
        });

        actorsContainer.appendChild(actorsUl);
        detailsUl.appendChild(actorsContainer);
        reviewsContainer.appendChild(reviewsUl);
        detailsUl.appendChild(reviewsContainer);

        return detailsUl;
    }

	scope.loadHtml = loadHtml;
}(imdb));