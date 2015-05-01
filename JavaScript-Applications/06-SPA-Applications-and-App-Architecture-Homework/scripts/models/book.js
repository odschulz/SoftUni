define([], function () {
    function Book(id, title, author, isbn) {
        this.id = id;
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }

    return  {
        load: function (id, title, author, isbn) {
            return new Book(id, title, author, isbn);
        }
    };
});