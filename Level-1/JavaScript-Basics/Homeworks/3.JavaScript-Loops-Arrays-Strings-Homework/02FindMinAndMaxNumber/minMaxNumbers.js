function findMinAndMax(arr) {
	var smallest = 0,
	biggest = 0;
	for (var i = 1; i < arr.length; i++) {
		if (arr[i] < arr[smallest]) {
			smallest = i;
		}
		if (arr[i] > arr[biggest]) {
			biggest = i;
		}
	}
	return 'Min -> ' + arr[smallest] + ' ' + 'Max -> '+ arr[biggest];
}

var inputNumbers = [
	[1, 2, 1, 15, 20, 5, 7, 31],
	[2, 2, 2, 2, 2],
	[500, 1, -23, 0, -300, 28, 35, 12]
];

console.log(findMinAndMax(inputNumbers[0]));
console.log(findMinAndMax(inputNumbers[1]));
console.log(findMinAndMax(inputNumbers[2]));