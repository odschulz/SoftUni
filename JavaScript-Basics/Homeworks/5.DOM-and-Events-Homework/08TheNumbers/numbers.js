function solve(input) {
	var output = [];
	var numbers = input[0].split(/\D+/).filter(Boolean);
	for (var i = 0; i < numbers.length; i++) {
		output[i] = Number(numbers[i]).toString(16).toUpperCase();
		if (output[i].length < 4) {
			output[i] = '0x' + Array(5 - output[i].length).join('0') + output[i];
		} else {
			output[i] = '0x' + output[i];
		}
	}
	console.log(output.join('-'));
}

var arr = [
	'5tffwj(//*7837xzc2---34rlxXP%$”.'
];

solve(arr);