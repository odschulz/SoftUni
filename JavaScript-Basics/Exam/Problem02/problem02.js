function solve(arr) {
	var input = [];
	var output = [];
	for (var i = 0; i < arr.length; i++) {
		input[i] = arr[i].toLowerCase().split('');
		output[i] = arr[i].split('');
	}
	// console.log(input);
	for (var row = 0; row < input.length - 2; row++) {
		if (input[row].length > 1 && input[row + 1].length > 2 && input[row +2].length > 1) {
			for (var col = 1; col < input[row].length; col++) {
				if (input[row][col] == input[row + 1][col - 1] &&
					input[row][col] == input[row + 1][col] &&
					input[row][col] == input[row + 1][col + 1] &&
					input[row][col] == input[row + 2][col]) {

					output[row][col] = '';
					output[row + 1][col - 1] = '';
					output[row + 1][col] = '';
					output[row + 1][col + 1] = '';
					output[row + 2][col] = '';
				}
			}
		}
	}
	for(var array in output){
		console.log(output[array].join(''));
	}
}

var test = [
	'ab**l5',
	'bBb*555',
	'absh*5',
	'ttHHH',
	'ttth'
];
// input = [
// 	'ax',
// 	'xxx',
// 	'b',
// 	'bbb',
// 	'bbbb'
// ];

solve(test);