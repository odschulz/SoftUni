function lastDigitAsText(number) {
	var lastDigit = Math.abs(number) % 10;
	switch (lastDigit) {
		case 1:
			return 'One';
		case 2:
			return 'Two';
		case 3:
			return 'Three';
		case 4:
			return 'Four';
		case 5:
			return 'Five';
		case 6:
			return 'Six';
		case 7:
			return 'Seven';
		case 8:
			return 'Eight';
		case 9:
			return 'Nine';
		default:
			return 'Not a number';
	}
}

var input = [6, -55, 133, 14567];

for (var i = 0; i < input.length; i++) {
	console.log(lastDigitAsText(input[i]));
}