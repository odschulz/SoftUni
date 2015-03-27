function reverseString(str) {
	str = str.split('').reverse().join('');
	console.log(str);
}
var inputs = [
	'sample',
	'softUni',
	'java script'
];
reverseString(inputs[0]);
reverseString(inputs[1]);
reverseString(inputs[2]);