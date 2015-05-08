var app = app || {};

app.homeViews = (function() {
    function HomeViews() {
        this.homeView = {
            loadHomeView : loadHomeView
        };

        this.welcomeView = {
            loadWelcomeView : loadWelcomeView
        };
    }

    function loadHomeView (selector, data) {
        $.get('templates/home.html', function(template) {
            var outHtml = Mustache.render(template, data);
            $(selector).html(outHtml);
        });
    }

    function loadWelcomeView (selector) {
        $.get('templates/welcome.html', function(template) {
            var outHtml = Mustache.render(template);
            $(selector).html(outHtml);
        });
    }

    return {
        load: function() {
            return new HomeViews();
        }
    };
}());