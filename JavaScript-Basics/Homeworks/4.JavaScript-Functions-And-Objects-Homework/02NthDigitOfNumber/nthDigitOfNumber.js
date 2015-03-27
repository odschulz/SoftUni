function findNthDigit(arr) {
	// var n = arr[0][0];
	var n = arr[0],
		num = arr[1].toString().replace(/\D+/g, '').split('').reverse().join('');
	if (num.length < n) {
		return 'The number doesn’t have 6 digits';
	}
	return num.charAt(n - 1);
}

var input = [
	[1, 6],
	[2, -55],
	[6, 923456],
	[3, 1451.78],
	[6, 888.88]
];

for (var i = 0; i < input.length; i++) {
	console.log(findNthDigit(input[i]));
}