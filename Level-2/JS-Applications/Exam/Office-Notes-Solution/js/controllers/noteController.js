var app = app || {};

app.noteController = (function () {
    function NoteController(model, views) {
        this.model = model;
        this.viewBag = views;
    }

    NoteController.prototype.loadAddNoteView = function(selector) {
        this.viewBag.addNote.addNoteView(selector);
    };

    NoteController.prototype.listOfficeNotes = function (selector) {
        var _this = this;
        var today = new Date();
        var todayDateToString =  ("0" + today.getDate()).slice(-2) + "-" + today.getDate() + "-" + today.getFullYear();

        return this.model.listOfficeNotes(todayDateToString)
            .then(function (data) {
                _this.viewBag.listOfficeNotes.loadOfficeNotesView(selector, data);
            }, function (error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });
    };

    NoteController.prototype.listMyNotes = function (selector) {
        var _this = this;
        var author = sessionStorage['fullName'];

        return this.model.listMyNotes(author)
            .then(function (data) {
                _this.viewBag.listMyNotes.loadMyNotesView(selector, data);
            }, function (error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });
    };

    NoteController.prototype.addNote = function (title, text, deadline, author) {
        return this.model.addNote(title, text, deadline, author)
            .then(function() {
                window.location.replace('#/myNotes/');
                Noty.success('Note successfully added!', 'topCenter');
            }, function(error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });
    };

    NoteController.prototype.editNote = function (noteId, title, text, deadline) {

        return this.model.editNote(noteId, title, text, deadline)
            .then(function() {
                window.location.replace('#/myNotes/');
            }, function(error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });
    };

    NoteController.prototype.loadEditNoteView = function (selector, noteId, title, text, deadline, author) {
        var date = deadline.split('-');
        for (var i = 0; i < date.length - 1; i += 1) {
                
            if (date[i].length == 1) {
                date[i] = '0' + date[i];
            }
        }

        var dateInCorrectFormat = date[2] + '-' + date[0] + '-' + date[1];

        data = {
            noteId: noteId,
            title: title,
            text: text,
            deadline: dateInCorrectFormat,
            author: author
        };
        
        this.viewBag.editNote.editNoteView(selector, data);
    };

    NoteController.prototype.deleteNote = function (noteId) {
        return this.model.deleteNote(noteId)
            .then(function() {
                window.location.replace('#/myNotes/');
            }, function(error) {
                console.log(error);
            });
    };

    return {
        load: function (model, views) {
            return new NoteController(model, views);
        }
    };
}());
