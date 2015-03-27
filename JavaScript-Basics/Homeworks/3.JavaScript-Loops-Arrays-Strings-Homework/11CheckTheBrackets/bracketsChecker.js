function checkBrackets(str) {
	var openBr = '',
		closeBr = '';
		str = str.replace(/[^()]/g,"");
	for (var i = 0; i < str.length; i++) {
		if (str.charAt(i) === '(') {
			openBr++;
		} else if (str.charAt(i) === ')') {
			closeBr++;
		}
	}
	if (openBr === closeBr && str.charAt(0) == '(') {
		console.log('correct');
	} else {
		console.log('incorrect');
	}
	console.log(str);
}
var inputs = [
	'( ( a + b ) / 5 – d )',
	') ( a + b ) )',
	'( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'
];
checkBrackets(inputs[0]);
checkBrackets(inputs[1]);
checkBrackets(inputs[2]);