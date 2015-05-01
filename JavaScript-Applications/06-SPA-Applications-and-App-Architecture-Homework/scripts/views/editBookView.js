define(['Q', 'jquery', 'Mustache'], function (Q, $, Mustache) {
    function renderAddBook(selector, controller, book) {
        $.get('templates/editBook.html', function (template) {
            var output = Mustache.render(template, book);

            $(selector).html(output);
        })
            .then(function () {
                $('#submit-button').on('click', function () {
                    var title = $('#title').val();
                    var author = $('#author').val();
                    var isbn = $('#isbn').val();

                    if (confirm('Are you sure you want to change this book')) {
                        controller.editBook(title, author, isbn, book.id);
                    }
                });

                $('#delete-button').on('click', function () {
                    if (confirm('Are you sure you want to delete this book')) {
                        controller.deleteBook(book.id);
                    }
                });

                $('#back-button').on('click', function () {
                    window.history.back();
                });
            }, function (error) {
                console.log(error);
            });
    }

    return {
        render: function (selector, controller, book) {
            renderAddBook(selector, controller, book);
        }
    };

});
