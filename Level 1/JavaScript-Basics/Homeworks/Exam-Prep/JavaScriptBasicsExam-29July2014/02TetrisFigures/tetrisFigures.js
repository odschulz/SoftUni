function findFigures(arr) {
	var figures = {'I': 0, 'L': 0, 'J': 0, 'O': 0, 'Z': 0, 'S': 0, 'T': 0};
	for (var i = 0; i < arr.length; i++) {
		for (var j = 0; j < arr[i].length; j++) {
			if (findI(i, j, arr)) {
				figures.I += 1;
			}
			if (findL(i, j, arr)) {
				figures.L += 1;
			}
			if (findJ(i, j, arr)) {
				figures.J += 1;
			}
			if (findO(i, j, arr)) {
				figures.O += 1;
			}
			if (findZ(i, j, arr)) {
				figures.Z += 1;
			}
			if (findS(i, j, arr)) {
				figures.S += 1;
			}
			if (findT(i, j, arr)) {
				figures.T += 1;
			}

		}
	}

	function findI(row, col, arr) {
		if (row + 4 <= arr.length) {
			if (arr[row].charAt(col) === 'o' && arr[row + 1].charAt(col) === 'o' && arr[row + 2].charAt(col) === 'o' && arr[row + 3].charAt(col) === 'o') {
				return true;
			}
		}
	}

	function findL(row, col, arr) {
		if (row + 3 <= arr.length && col + 2 <= arr[0].length) {
			if (arr[row].charAt(col) === 'o' && arr[row + 1].charAt(col) === 'o' && arr[row + 2].charAt(col) === 'o' && arr[row + 2].charAt(col + 1) === 'o') {
				return true;
			}
		}
	}

	function findJ(row, col, arr) {
		if (row + 3 <= arr.length && col > 0) {
			if (arr[row].charAt(col) === 'o' && arr[row + 1].charAt(col) === 'o' && arr[row + 2].charAt(col) === 'o' && arr[row + 2].charAt(col - 1) === 'o') {
				return true;
			}
		}
	}

	function findO(row, col, arr) {
		if (row + 2 <= arr.length && col + 2 <= arr[0].length) {
			if (arr[row].charAt(col) === 'o' && arr[row].charAt(col +1) === 'o' && arr[row + 1].charAt(col) === 'o' && arr[row + 1].charAt(col + 1) === 'o') {
				return true;
			}
		}
	}

	function findZ(row, col, arr) {
		if (row + 2 <= arr.length && col + 3 <= arr[0].length) {
			if (arr[row].charAt(col) === 'o' && arr[row].charAt(col + 1) === 'o' && arr[row + 1].charAt(col + 1) === 'o' && arr[row + 1].charAt(col + 2) === 'o') {
				return true;
			}
		}
	}

	function findS(row, col, arr) {
		if (row > 0 && col + 3 <= arr[0].length) {
			if (arr[row].charAt(col) === 'o' && arr[row].charAt(col + 1) === 'o' && arr[row - 1].charAt(col + 1) === 'o' && arr[row - 1].charAt(col + 2) === 'o') {
				return true;
			}
		}
	}

	function findT(row, col, arr) {
		if (row + 2 <= arr.length && col + 3 <= arr[0].length) {
			if (arr[row].charAt(col) === 'o' && arr[row].charAt(col + 1) === 'o' && arr[row].charAt(col + 2) === 'o' && arr[row + 1].charAt(col + 1) === 'o') {
				return true;
			}
		}
	}
	console.log(JSON.stringify(figures));
}

input = [
	'--o--o-',
	'--oo-oo',
	'ooo-oo-',
	'-ooooo-',
	'---oo--'
];
findFigures(input);