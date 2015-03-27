function findMaxSequence(arr) {
	var sequenceEnd,
		counter = 1,
		tempCounter = 1,
		outpurArr = [];
	for (var i = 0; i < arr.length; i++) {
		if (arr[i] === arr[i + 1]) {
			tempCounter++;
		} else {
			if (tempCounter >= counter) {
				counter = tempCounter;
				tempCounter = 1;
				sequenceEnd = i + 1; // because the slice method will take all numbers until sequenceEnd+1
			} else {
				tempCounter = 1;
			}
		}
	}
	outpurArr = arr.slice((sequenceEnd - counter), (sequenceEnd));
	console.log(outpurArr);
}
var input = [
	[2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
	['happy'],
	[2, 'qwe', 'qwe', 3, 3, '3']
];
findMaxSequence(input[0]);
findMaxSequence(input[1]);
findMaxSequence(input[2]);