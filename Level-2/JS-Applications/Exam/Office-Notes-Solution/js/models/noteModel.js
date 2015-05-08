var app = app || {};

app.noteModel = (function() {
    function NoteModel(baseUrl, requester, headers) {
        this.serviceUrl = baseUrl + 'classes/Note/';
        this.requester = requester;
        this.headers = headers;
    }

    NoteModel.prototype.addNote = function(title, text, deadline, author) {
        var userId = sessionStorage['userId'];
        var data = {
            title: title,
            text: text,
            deadline: deadline,
            author: author,
            ACL : {}
        };

        data.ACL[userId] = {"write":true,"read":true};
        data.ACL["*"] = {"read":true };


        return this.requester.post(this.serviceUrl, this.headers.getHeaders(true), data);
    };

    NoteModel.prototype.editNote = function(noteId, title, text, deadline) {
        var data = {
            title: title,
            text: text,
            deadline: deadline
        };

        return this.requester.put(this.serviceUrl + noteId, this.headers.getHeaders(true), data);
    };

    NoteModel.prototype.deleteNote = function(noteId) {
        return this.requester.remove(this.serviceUrl + noteId, this.headers.getHeaders(true));
    };

    NoteModel.prototype.listOfficeNotes = function(date) {
        var url = this.serviceUrl + '?where={\"deadline\":\"' + date + '\"}';
        return this.requester.get(url, this.headers.getHeaders(true));
    };

    NoteModel.prototype.listMyNotes = function(author) {
        var url = this.serviceUrl + '?where={\"author\":\"' + author + '\"}';

        return this.requester.get(url, this.headers.getHeaders(true));
    };

    return {
        load: function(baseUrl, requester, headers) {
            return new NoteModel(baseUrl, requester, headers);
        }
    }
}());
