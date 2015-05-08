function solve(arr) {
	var output = [];
	for (var i = 0; i < arr.length; i++) {
		output[i] = arr[i].split('');
	}
	for (var row = 0; row < arr.length - 1; row++) {
		if (arr[row].length > 1 && arr[row + 1].length > 2) {
			for (var col = 1; col < arr[row].length; col++) {
				if (arr[row][col] == arr[row + 1][col - 1] &&
					arr[row][col] == arr[row + 1][col] &&
					arr[row][col] == arr[row + 1][col + 1]) {

					output[row][col] = '*';
					output[row + 1][col - 1] = '*';
					output[row + 1][col] = '*';
					output[row + 1][col + 1] = '*';
				}
			}
		}
	}
	for(arr in output){
		console.log(output[arr].join(''));
	}
}

var input = [
	'abcdexgh',
	'bbbdxxxh',
	'abcxxxxx'
];
// input = [
// 	'ax',
// 	'xxx',
// 	'b',
// 	'bbb',
// 	'bbbb'
// ];

solve(input);