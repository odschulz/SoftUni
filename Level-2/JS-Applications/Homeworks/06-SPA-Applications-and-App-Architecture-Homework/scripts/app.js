require.config({
    paths: {
        'jquery': 'libs/jquery-2.1.3.min',
        'Sammy': 'libs/sammy-latest.min',
        'Mustache': 'libs/mustache.min',
        'Q': 'libs/q',
        '_': 'libs/lodash',
        'Headers': 'models/headers',
        'Requester': 'models/requester',
        'Book': 'models/book',
        'BookModel': 'models/bookModel',
        'BookController': 'controllers/bookController',
        'AllBooksView': 'views/allBooksView',
        'AddBookView': 'views/addBookView',
        'EditBookView': 'views/editBookView'
    }
});

require(['Headers', 'Requester', 'BookModel', 'BookController', 'Sammy'],
    function (Headers, Requester, BookModel, BookController, Sammy) {
    	var appId = 'yVgcchHTgspuz2IALADDsXOGAyBDoy18tmbcxOC0';
    	var restAPIKey = '5nTL0oyCUsivv9LXIbFxYCQzAIqU3KDqTsgzNF05';
        var baseUrl = 'https://api.parse.com/1/';
        var selector = '#books-wrapper';

        var headers = Headers.load(appId, restAPIKey);
        var requester = Requester.load();
        var bookModel = BookModel.load(headers, baseUrl, requester);
        var bookController = BookController.load(bookModel, selector);

        var router = Sammy(function () {

            this.get('#!/', function(context) {
                bookController.loadBooks();
            });

            this.get('#!/add', function(context) {
                bookController.loadAddBookView();
            });

            this.get('#!/edit/:id', function(context) {
                var bookId = context.params.id;

                bookController.loadEditBookView(bookId);

            });
        });

        router.run('#!/');

    });