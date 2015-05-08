function countDivs(html) {
	var regexp = new RegExp(/<\/? *div[^>]*>/g);
	return html.match(regexp).length / 2;
}

var input = [
'<!DOCTYPE html>',
'<html>',
'<head lang="en">',
    '<meta charset="UTF-8">',
    '<title>index</title>',
    '<script src="/yourScript.js" defer></script>',
'</head>',
'<body>',
    '<div id="outerDiv">',
        '<div',
    'class="first">',
            '<div><div>hello</div></div>',
        '</div>',
        '<div>hi<div></div></div>',     
        '<div>I am a div</div>',
    '</div>',
'</body>',
'</html>'
].join('');

console.log(countDivs(input));