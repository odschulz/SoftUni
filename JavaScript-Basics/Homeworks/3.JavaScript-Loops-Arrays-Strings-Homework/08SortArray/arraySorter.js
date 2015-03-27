function sortArray(arr) {
	var a, b;
	for (a = 0; a < arr.length - 1; a++) {
		for (b = a + 1; b < arr.length; b++) {
			if (arr[b] < arr[a]) {
				arr[a] = arr[a] + arr[b];
				arr[b] = arr[a] - arr[b];
				arr[a] = arr[a] - arr[b];
			}
		}
	}
	console.log(arr);
}
var inputs = [
	[5, 4, 3, 2, 1],
	[12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]
];
sortArray(inputs[0]);
sortArray(inputs[1]);