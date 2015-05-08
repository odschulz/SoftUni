define(['Q', 'jquery', 'Mustache'], function (Q, $, Mustache) {
    function renderAddBook(selector, controller) {
        $.get('templates/addBook.html', function (template) {
            var output = Mustache.render(template);
            $(selector).html(output);
        })
            .then(function () {
                $('#add-book').on('click', function () {
                    var title = $('#title').val();
                    var author = $('#author').val();
                    var isbn = $('#isbn').val();
                    
                    controller.addBook(title, author, isbn);
                });

                $('#back-button').on('click', function () {
                    window.history.back();
                });
            }, function (error) {
                console.log(error);
            });
    }

    return {
        render: function (selector, controller) {
            renderAddBook(selector, controller);
        }
    };

});
