function findMostFreqNum(arr) {
	var counter = 1,
		tempCounter = 1,
		value = arr[0],
		i, j;
	for (i = 0; i < arr.length - 1; i++) {
		for (j = i + 1; j < arr.length; j++) {
			if (arr[i] === arr[j]) {
				tempCounter++;
			}
		}
		if (tempCounter > counter) {
			counter = tempCounter;
			value = arr[i];
		}
		tempCounter = 1;
	}
	console.log(value + ' (' + counter + ' times)');
}
var inputs = [
	[4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
	[2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1],
	[1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]
];
findMostFreqNum(inputs[0]);
findMostFreqNum(inputs[1]);
findMostFreqNum(inputs[2]);