(function() {

    var appId= '4Jq7XQZVZktZRbZp2Tw4Dhyzu1PxdRO52M1Ay4sI';
    var restAPI = '4hd4uweDo8OOwvfcuexC5dWbwTVagsQmgkOtRBrv';
    var baseUrl = 'https://api.parse.com/1/';

    var headers = app.headers.load(appId, restAPI);
    var requester = app.requester.load();
    var userModel = app.userModel.load(baseUrl, requester, headers);
    var noteModel = app.noteModel.load(baseUrl, requester, headers);
    
    var homeViews = app.homeViews.load();
    var userViews = app.userViews.load();
    var noteViews = app.noteViews.load();
    
    var homeController = app.homeController.load(homeViews);
    var userController = app.userController.load(userModel, userViews);
    var noteController = app.noteController.load(noteModel, noteViews);


    app.router = Sammy(function () {
        var selector = '#container';

        this.before(function(context) {
            var userId = sessionStorage['userId'];
            if(userId) {
                $('#welcomeMenu').text('Welcome, ' + sessionStorage.username);
                $('#menu').show();
            } else {
                $('#menu').hide();
            }
        });

        this.before('#/home/', function() {
            var userId = sessionStorage['userId'];
            if(!userId) {
                this.redirect('#/');
                return false;
            }
        });

        this.before('#/logout/', function() {
            var userId = sessionStorage['userId'];
            if(!userId) {
                this.redirect('#/');
                return false;
            }
        });

        this.get('#/', function () {
            homeController.welcomeScreen(selector);
        });

        this.get('#/login/', function() {
            userController.loadLoginPage(selector);
        });

        this.get('#/register/', function() {
            userController.loadRegisterPage(selector);
        });

        this.get('#/logout/', function() {
            userController.logout();
        });

        this.get('#/home/', function () {
            homeController.homeScreen(selector);
        });

        this.get('#/office/', function() {
            noteController.listOfficeNotes(selector);
        });

        this.get('#/myNotes/', function() {
            noteController.listMyNotes(selector);
        });

        this.get('#/addNote/', function() {
            noteController.loadAddNoteView(selector);
        });

        this.get('#/myNotes/editNote/:id', function() {

        });

        this.bind('login', function(e, data) {
            userController.login(data.username, data.password);
        });

        this.bind('register', function(e, data) {
            userController.register(data.username, data.password, data.fullName);
        });

        this.bind('addNote', function(e, data) {
            noteController.addNote(data.title, data.text, data.deadline, data.author);
        });

        this.bind('editNote', function(e, data) {
            noteController.loadEditNoteView(selector, data.noteId, data.title, data.text, data.deadline, data.author);

        });

        this.bind('submitEditedNote', function(e, data) {
            noteController.editNote(data.noteId, data.title, data.text, data.deadline);
        });
    });

    app.router.run('#/');

}());