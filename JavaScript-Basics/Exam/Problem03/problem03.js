function solve(input) {
    var regex = /(.*\?{1})?(\+*[%20]*\w+\+*[%20]*\w*\+*[%20]*)=([^&]+)/g;
    var match;
    // var output = {};
    var fieldVar, valueVar;
    for (var i = 0; i < input.length; i++) {
        var output = {};
        while (match = regex.exec(input[i])) {
            fieldVar = match[2];
            valueVar = match[3];
            if (fieldVar.indexOf('+') > -1 || fieldVar.indexOf('%20' > -1)) {
                fieldVar = fieldVar.split('+').filter(Boolean).join(' ');
                fieldVar = fieldVar.split('%20').filter(Boolean).join(' ');
                fieldVar = fieldVar.split(' ').filter(Boolean).join(' ');
            }
            if (!output[fieldVar]) {
                output[fieldVar] = [];
            }
            if (valueVar.indexOf('+' > -1) || valueVar.indexOf('%20' > -1)) {
                valueVar = valueVar.split('+').filter(Boolean).join(' ');
                valueVar = valueVar.split('%20').filter(Boolean).join(' ');
                valueVar = valueVar.split(' ').filter(Boolean).join(' ');
                output[fieldVar].push(valueVar);
            } else {
                output[fieldVar].push(valueVar);
            }
        }
        str = (JSON.stringify(output));
        str = str.split('}').join('');
        str = str.split('{').join('');
        str = str.split('\"').join('');
        str = str.split('],').join(']');
        str = str.split(',').join(', ');
        str = str.split(':').join('{');
        var pattern = '';
        var replacement = '';
        for (key in output) {
            pattern = key + '{';
            replacement = key + '=';
            str = str.split(pattern).join(replacement);
        }
        str = str.split('{').join(':');
        console.log(str);
    }

}

var arr = [
    'login%20=student&password=student'
];
arr = [
    'field=value1&field=value2&field=value3',
    'http://example.com/over/there?name=ferret'
];
arr = [
    '++%20foo++%20++%20=++%20foo%20++&value=+++%20val+++&foo+=++++5+%20++%20203',
    'foo=poo%20&value=valley&dog=wow+',
    'url=https://softuni.bg/trainings/coursesinstances/details/1070',
    'https://softuni.bg/trainings?trainer=nakov&course=oop&course=php'
];
solve(arr);