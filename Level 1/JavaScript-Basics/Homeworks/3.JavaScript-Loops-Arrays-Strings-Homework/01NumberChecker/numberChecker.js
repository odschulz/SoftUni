function printNumbers(number) {
	var output = [];
	if (number > 1) {
		for (var i = 1; i <= number; i++) {
			if (i % 4 !== 0 & i % 5 !== 0) {
				output.push(i);
			}
		}
	} else {
		output.push('no');
	}
	console.log(output.join(', '));
}
printNumbers(20);
printNumbers(-5);
printNumbers(13);