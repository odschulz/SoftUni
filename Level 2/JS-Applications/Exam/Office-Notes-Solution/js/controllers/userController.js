var app = app || {};

app.userController = (function() {
    function UserController(model, views) {
        this.model = model;
        this.viewBag = views;
    }

    UserController.prototype.loadLoginPage = function(selector) {
        this.viewBag.loginView.loadLoginView(selector);
    };

    UserController.prototype.loadRegisterPage = function(selector) {
        this.viewBag.registerView.loadRegisterView(selector);
    };

    UserController.prototype.login = function(username, password) {
        return this.model.login(username, password)
            .then(function(loginData) {
                setUserToStorage(loginData);
                window.location.replace('#/home/');
                Noty.success('You have successfully logged in!', 'topCenter');
            }, function(error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });
    };

    UserController.prototype.register = function(username, pass, fullName) {
        return this.model.register(username, pass, fullName)
            .then(function(registerData) {
                var data = {
                    username: username,
                    fullName: fullName,
                    objectId: registerData.objectId,
                    sessionToken: registerData.sessionToken
                };

                setUserToStorage(data);
                window.location.replace('#/home/');
                Noty.success('You have successfully registered!', 'topCenter');
            }, function(error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });
    };

    UserController.prototype.logout = function() {
        return this.model.logout()
            .then(function() {
                clearUserFromStorage();
                window.location.replace('#/');
                Noty.success('You have successfully logged out!', 'topCenter');
            }, function(error) {
                Noty.error(error.responseJSON.error, 'topCenter');
            });

    };

    function setUserToStorage(data) {
        sessionStorage['username'] = data.username;
        sessionStorage['userId'] = data.objectId;
        sessionStorage['fullName'] = data.fullName;
        sessionStorage['sessionToken'] = data.sessionToken;
    }

    function clearUserFromStorage() {
        delete sessionStorage['username'];
        delete sessionStorage['userId'];
        delete sessionStorage['fullName'];
        delete sessionStorage['sessionToken'];
    }

    return {
        load : function(model, views) {
            return new UserController(model, views);
        }
    };
}());