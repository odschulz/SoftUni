function findLargestBySumOfDigits(arr) {
	var i, j, sum = Number.MIN_VALUE,
		number;
	for (i = 0; i < arr.length; i++) {
		if (isNaN(arr[i])) {
			return undefined;
		} else {
			var tempSum = findSum(arr[i]);
			if (tempSum > sum) {
				sum = tempSum;
				number = arr[i];
			}
		}

	}
	return number;
}

function findSum(number) {
	number = Math.abs(number).toString();
	sum = 0;
	for (var i = 0; i < number.length; i++) {
		sum += Number(number.charAt(i));
	}
	return sum;
}

var input = [
	[5, 10, 15, 111],
	[33, 44, -99, 0, 20],
	['hello']
];

for (var i = 0; i < input.length; i++) {
	console.log(findLargestBySumOfDigits(input[i]));
}