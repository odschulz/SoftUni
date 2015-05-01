var app = app || {};

(function() {
    app.router = Sammy(function () {
        var selector = '#wrapper';

        this.get('#/', function(context) {
            $.get('templates/home.html', function(template) {
            	$(selector).html(template);
            });
        });

        this.get('#/:name', function(context) {
        	var name = context.params.name;

        	$.get('templates/name.html', function(template) {
        		var data = {};
        		data.name = name;

        		var result = Mustache.render(template, data);

        		$(selector).html(result);
        	});
        });
    });

    app.router.run('#/');
}());
