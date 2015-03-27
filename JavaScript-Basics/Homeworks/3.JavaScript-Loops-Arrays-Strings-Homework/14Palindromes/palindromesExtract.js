function findPalindromes(str) {
	var palindromes = [];
	str = str.toLowerCase().replace(/[\.,-\/#!$%\^&\*;:{}=\-_`~()]/g,"").split(' ');
	for (var i = 0; i < str.length; i++) {
		if (str[i] === str[i].split('').reverse().join('')) {
			palindromes.push(str[i]);
		}
	}
	console.log(palindromes.join(', '));
}
findPalindromes('There is a man, his name was Bob.');