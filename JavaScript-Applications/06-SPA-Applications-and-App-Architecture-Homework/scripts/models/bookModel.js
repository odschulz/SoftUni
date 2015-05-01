define(['Q', 'Book'], function (Q, Book) {
    function BookModel(headers, baseUrl, requester) {
        this._headers = headers;
        this._requester = requester;
        this._serviceUrl = baseUrl + 'classes/Book/';
        this._bookRepo = {
            books: []
        };
    }

    BookModel.prototype.getAllBooks = function getAllBooks() {
        var url = this._serviceUrl;
        var headers = this._headers.getHeaders();
        var _this = this;
        var deferred = Q.defer();
        
        this._bookRepo.books.length = 0;

        this._requester.get(url, headers)
            .then(function (booksData) {
                booksData.results.forEach(function (book) {
                    var bookObject = Book.load(book.objectId, book.title, book.author, book.isbn);

                    _this._bookRepo.books.push(bookObject);
                });

                deferred.resolve(_this._bookRepo);
            },
            function (error) {
                deferred.reject(error);
            });

        return deferred.promise;
    };

    BookModel.prototype.addBook = function addBook(book) {
        var url = this._serviceUrl;
        var headers = this._headers.getHeaders();

        return this._requester.post(url, headers, book);
    };

    BookModel.prototype.editBook = function editBook(book, bookId) {
        var url = this._serviceUrl + bookId;
        var headers = this._headers.getHeaders();

        return this._requester.put(url, headers, book);
    };

    BookModel.prototype.deleteBook = function deleteBook(bookId) {
        var url = this._serviceUrl + bookId;
        var headers = this._headers.getHeaders();

        return this._requester.del(url, headers);
    };

    return  {
        load: function (headers, requester, baseUrl) {
            return new BookModel(headers, requester, baseUrl);
        }
    };
});