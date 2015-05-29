app.directive('defaultImage', function() {
    return {
        link: function(scope, element, attrs) {
            //element.bind('error', function() {
            //    if (attrs.src != attrs.defaultImage) {
            //        attrs.$set('src', attrs.defaultImage);
            //    }
            //});

            attrs.$observe('ngSrc', function(value) {
                if (!value && attrs.defaultImage) {
                    attrs.$set('src', attrs.defaultImage);
                }
            });
        }
    }
});