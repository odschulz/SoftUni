define(['Mustache', 'Q', '_', 'AllBooksView', 'AddBookView', 'EditBookView','Book'],
    function (Mustache, Q, _, AllBooksView, AddBookView, EditBookView, Book) {

        function BookController(model, selector) {
            this._model = model;
            this._selector = selector;
        }

        BookController.prototype.loadBooks = function loadBooks() {
            var _this = this;

            this._model.getAllBooks()
               .then(function (booksData) {
                    AllBooksView.render(_this, _this._selector, booksData);

               }, function (error) {
                   console.error(error.responseText);
               });
        };

        BookController.prototype.addBook = function addBook(title, author, isbn) {
            var _this = this,
                book = {
                    title: title,
                    author: author,
                    isbn: isbn
                };

            this._model.addBook(book)
                .then(function (booksData) {
                    _this.loadBooks();
                }, function (error) {
                    console.log(error);
                    alert('cannot add book, check console for error');
                });
        };

        BookController.prototype.editBook = function editBook(title, author, isbn, bookId) {
            var _this = this,
                book = {
                    title: title,
                    author: author,
                    isbn: isbn
                };

            this._model.editBook(book, bookId)
                .then(function (booksData) {
                    _this.loadBooks();
                }, function (error) {
                    console.log(error);
                    alert('cannot edit book, check console for error');
                });
        };

        BookController.prototype.deleteBook = function deleteBook(bookId) {
            var _this = this;

            this._model.deleteBook(bookId)
                .then(function (booksData) {
                    _this.loadBooks();
                }, function (error) {
                    console.log(error);
                    alert('cannot delete book, check console for error');
                });
        };

        BookController.prototype.loadAddBookView = function loadAddBookView() {
            AddBookView.render(this._selector, this);
        };

        BookController.prototype.loadEditBookView = function loadEditBookView(bookId) {
            var _this = this;
            this._model.getAllBooks()
                .then(function () {
                    var book = _.chain(_this._model._bookRepo.books).where({"id": bookId}).first().value();

                    EditBookView.render(_this._selector, _this, book);

                }, function (error) {
                    console.error(error.responseText);
                });
        };

        return  {
            load: function (model, selector) {
                return new BookController(model, selector);
            }
        };
    });