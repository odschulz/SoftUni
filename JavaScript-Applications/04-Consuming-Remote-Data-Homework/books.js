$(document).ready(function(){
	var headers = {
			'X-Parse-Application-Id': 'yVgcchHTgspuz2IALADDsXOGAyBDoy18tmbcxOC0',
			'X-Parse-REST-API-Key': '5nTL0oyCUsivv9LXIbFxYCQzAIqU3KDqTsgzNF05',
			"Content-Type": "application/json"
		},
		appUrl = 'https://api.parse.com/1/classes/Book/';


	$('#submit-book-button').on('click', addBook);
	getBooks();

	function getBooks() {
		$('#books-container').html('');
		$.ajax({
			url: appUrl,
			method: 'GET',
			headers: headers
		}).success(visualizeBooks)
		.error(function (err) {
			console.log(err);
		});
	}

	function deleteBook() {
		var bookId = $(this).parent().data('bookId'),
			_that = this;

		$.ajax({
			url: appUrl + bookId,
			method: 'DELETE',
			headers: headers
		}).success(function deleteFromDom() {
			$(_that).parent().remove();
		})
		.error(function (err) {
			console.log(err);
		});
	}

	function editBook(argument) {
		var book,
			siblings,
			inputsToEdit,
			title,
			author,
			isbn,
			submitButton;

		book = $(this).parent();
		detailsContainer = book.children('.book-details-container');
		inputsToEdit = detailsContainer.children('.book-details-container > input');

		// title = detailsContainer.children('#title').val();
		// author = detailsContainer.children('#author').val();
		// isbn = detailsContainer.children('#isbn').val();

		inputsToEdit.removeAttr('disabled');
		submitButton = $('<button class="submit-changes-button">').text('submit');
		submitButton.on('click', submitChanges);
		book.append(submitButton);

		function submitChanges() {
			var bookId = book.data('bookId'),
				bookDetails = {
					title: detailsContainer.children('#title').val(),
					author: detailsContainer.children('#author').val(),
					isbn: detailsContainer.children('#isbn').val()
				};

			$.ajax({
				url: appUrl + bookId,
				method: 'PUT',
				headers: headers,
				data : JSON.stringify(bookDetails)
			}).success(getBooks)
			.error(function (err) {
				console.log(err);
			});
		}
	}

	function addBook() {
		var book = {
				title: $('#book-title').val(),
				author: $('#book-author').val(),
				isbn: $('#book-isbn').val()
			};

			$.ajax({
				url: appUrl,
				method: 'POST',
				headers: headers,
				data : JSON.stringify(book)
			}).success(getAddedBook)
			.error(function (err) {
				console.log(err);
			});

		function getAddedBook(data) {
			var bookId = data.objectId;

			$.ajax({
				url: appUrl + bookId,
				method: 'GET',
				headers: headers
			}).success(visualizeBooks)
			.error(function (err) {
				console.log(err);
			});
		}

	}

	function visualizeBooks(data) {
		var books = [],
			booksLength,
			i,
			book,
			title,
			author,
			isbn,
			deleteButton,
			editButton;

		if (data.results) {
			books = data.results;
		} else {
			books.push(data);
		}

		booksLength = books.length;

		for (i = 0; i < booksLength; i += 1) {
			//title = $('<inut type="text" value="' + books[i].title + '">');//.text(books[i].title);
			title = $('<div class="book-details-container">');
			title.append($('<label for="title" class="book-detail-label">').text('Title'));
			title.append($('<input class="book-detail">').attr({
								    type: 'text',
								    id: 'title',
								    value: books[i].title,
								    disabled: 'disabled'
								}));

			author = $('<div class="book-details-container">');
			author.append($('<label for="author" class="book-detail-label">').text('Author'));
			author.append($('<input class="book-detail">').attr({
								    type: 'text',
								    id: 'author',
								    value: books[i].author,
								    disabled: 'disabled'
								}));

			isbn = $('<div class="book-details-container">');
			isbn.append($('<label for="isbn" class="book-detail-label">').text('ISBN'));
			isbn.append($('<input class="book-detail">').attr({
								    type: 'text',
								    id: 'isbn',
								    value: books[i].isbn,
								    disabled: 'disabled'
								}));

			deleteButton = $('<button>').text('delete book').on('click', deleteBook);
			editButton = $('<button>').text('edit book').on('click', editBook);


			book = $('<div class="books">');
			$(book).data('bookId', books[i].objectId);
			//console.log(book.data('bookId'));
			book.append(title);
			book.append(author);
			book.append(isbn);
			book.append(deleteButton);
			book.append(editButton);


			book.appendTo($('#books-container'));

		}

		

	}


});