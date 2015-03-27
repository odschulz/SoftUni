function reverseWordsInString(str) {
	str = str.split(' ');
	for (var word in str) {
		str[word] = str[word].split('').reverse().join('');
	}
	return str.join(' ');
}

var input = [
	'Hello, how are you.',
	'Life is pretty good, isn’t it?'
];

for (var i = 0; i < input.length; i++) {
	console.log(reverseWordsInString(input[i]));
}