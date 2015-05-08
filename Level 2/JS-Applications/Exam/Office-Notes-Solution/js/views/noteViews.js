var app = app || {};

app.noteViews = (function() {
    function NoteViews() {
        this.listOfficeNotes = {
            loadOfficeNotesView: loadOfficeNotesView
        };

        this.listMyNotes = {
            loadMyNotesView: loadMyNotesView
        };

        this.addNote = {
            addNoteView: addNoteView
        };

        this.editNote = {
            editNoteView: editNoteView
        };

        this.deleteNote = {
            deleteNoteView: deleteNoteView
        }
    }

    function loadOfficeNotesView (selector, data) {
        $.get('templates/officeNoteTemplate.html', function (template) {
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);
        });
    }

    function loadMyNotesView (selector, data) {
        $.get('templates/myNoteTemplate.html', function (template) {
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);
        }).then(function() {
            $('.edit').click(function() {

                var noteId =$(this).parent().attr('data-id');
                var title = $($(this).siblings().children('#title')[0]).text();
                var text = $($(this).siblings().children('#text')[0]).text();
                var author = $($(this).siblings().children('.author')[0]).text();
                var deadline = $($(this).siblings().children('.deadline')[0]).text();


                $.sammy(function() {
                    this.trigger(
                        'editNote',
                        {
                            noteId: noteId, title: title, text: text, deadline: deadline, author: author
                        });
                });

                return false;
            })
        }).done();
    }

    function addNoteView (selector) {
        $.get('templates/addNote.html', function (template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);
        }).then(function() {
            $('#addNoteButton').click(function() {
                var title = $('#title').val();
                var text = $('#text').val();
                var date = new Date($('#deadline').val());
                var deadline =  ("0" + date.getDate()).slice(-2) + "-" + date.getDate() + "-" + date.getFullYear();
                var author = sessionStorage['fullName'];

                $.sammy(function() {
                    this.trigger('addNote', {title: title, text: text, deadline: deadline, author: author});
                });

                return false;
            })
        }).done();
    }

    function editNoteView (selector, data) {
        $.get('templates/editNote.html', function (template) {

            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);
            window.location.replace('#/myNotes/editNote/' + data.noteId);
        }).then(function() {
            $('#editNoteButton').click(function() {
                data.title = $('#title').val();
                data.text = $('#text').val();
                var date = new Date($('#deadline').val());
                data.deadline =  ("0" + date.getDate()).slice(-2) + "-" + date.getDate() + "-" + date.getFullYear();

                $.sammy(function() {
                    this.trigger('submitEditedNote', data);
                });
            });


        }).done();
    }

    function deleteNoteView (selector, data) {
        $.get('templates/delete-phone.html', function (template) {
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);
        }).then(function() {
            $('#deleteButton').click(function() {
                $.sammy(function() {
                    this.trigger('deletePhone', {id: data.id});
                });

                return false;
            })
        }).done();
    }

    return {
        load: function() {
            return new NoteViews();
        }
    }
}());