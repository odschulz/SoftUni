(function() {
    var data = {
        people: [
        {
            "jobTitle": "Front End Technician Lead",
            "name": "Garry Finch",
            "website": "http://website.com"
        },
        {
            "jobTitle": "Photographer",
            "name": "Bob McFry",
            "website": "http://goo.gle"
        },
        {
            "jobTitle": "Lego Geek",
            "name": "Jenny O'Sullivan",
            "website": "http://stackoverflow.com"
        }
    ]};

    $.get('templates/person.html', function (source) {
        var template = Handlebars.compile(source);
        $('#wrapper').append(template(data));
    });

}());
