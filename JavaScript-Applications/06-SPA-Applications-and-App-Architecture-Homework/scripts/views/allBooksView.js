define(['Q', 'jquery', 'Mustache'], function (Q, $, Mustache) {
    function renderAllBooks(controller, selector, data) {
        $.get('templates/allBooks.html', function (template) {
            var output = Mustache.render(template, data);
            $(selector).html(output);
        })
            .then(function () {
                //var editButtons = $('.edit-buttons');
                //$(editButtons).each(function (key, value) {
                //    var button = $(value),
                //        bookId = button.attr('id');
                //    //button.on('click', controller);
                //});

                if (location.hash !== '#!/') {
                    location.replace('#!/');
                }
            });
    }

    return {
        render: function (controller, selector, data) {
            renderAllBooks(controller, selector, data);
        }
    };

});