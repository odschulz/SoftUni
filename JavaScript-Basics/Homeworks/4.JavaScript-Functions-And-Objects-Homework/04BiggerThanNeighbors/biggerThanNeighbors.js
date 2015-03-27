	function biggerThanNeighbors(index, arr) {
		if (index < 0 || index > arr.length - 1) {
			return undefined;
		} else if (index === 0 || index === arr.length -1) {
			return 2;
		} else if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]) {
			return 1;
		} else {
			return 0;
		}
	}

	function printResult(arr) {
		if (biggerThanNeighbors(arr[0], arr[1]) === undefined) {
			console.log('invalid index');
		} else if (biggerThanNeighbors(arr[0], arr[1]) === 2) {
			console.log('only one neighbor');
		} else if (biggerThanNeighbors(arr[0], arr[1])) {
			console.log('bigger');
		} else {
			console.log('not bigger');
		}
	}

	var input = [
		[2, [1, 2, 3, 3, 5]],
		[2, [1, 2, 5, 3, 4]],
		[5, [1, 2, 5, 3, 4]],
		[0, [1, 2, 5, 3, 4]]
	];

	for (var i = 0; i < input.length; i++) {
		printResult(input[i]);
	}