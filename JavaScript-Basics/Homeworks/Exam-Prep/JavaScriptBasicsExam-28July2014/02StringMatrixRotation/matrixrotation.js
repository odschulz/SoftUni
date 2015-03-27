function StringMatrixRotation(input) {
	function loadMatrix(input) {
		var matrix = [];
		var i;
		var maxLength = 0;
		for (i = 1; i < input.length; i++) {
			if(input[i].length > maxLength){
				maxLength = input[i].length;
			}
		}
		for (i = 1; i < input.length; i++) {
			var row = input[i] + Array(maxLength - input[i].length + 1).join(' ');
			matrix.push(row.split(''));
		}
	}
	function rotateMatrix90(matrix) {
		var newMatrix = [];
		var i;
		for (var i = 0; i < matrix[0].length; i++) {
			newMatrix.push([]);
		}

		var row, newRow;
		var col, newCol;
		for (row = 0; row < matrix.length; row++) {
			newCol = matrix.length - row;
			for (col = 0; col < input[0].length; col++) {
				newRow = col;
				newMatrix[newRow][newCol] = matrix[row][col];
			}
		}
	}

	var degAsString = input[0].match(/\d+/g);
	var deg = Number(degAsString);
	var matrix = [];
	var rotateMatrix = [];

	matrix = loadMatrix(input);
	// rotateMatrix = rotateMatrix90(matrix);
	print(rotatedMatrix);
}
StringMatrixRotation(
	[
		'Rotate90',
		'hello',
		'softuni',
		'exam'
	]
);
// /\d+/g