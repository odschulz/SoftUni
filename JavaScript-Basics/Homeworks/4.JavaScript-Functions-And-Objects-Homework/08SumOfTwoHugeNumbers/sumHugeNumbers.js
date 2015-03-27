function sumTwoHugeNumbers(value) {
	var shorter, longer, remainder = 0,
		tempSum = 0,
		result = '',
		i;
	if (value[0].length >= value[1].length) {
		longer = value[0];
		shorter = value[1];
	} else {
		longer = value[1];
		shorter = value[0];
	}
	shorter = Array(longer.length - shorter.length + 1).join('0') + shorter;

	for (i = longer.length - 1; i >= 0; i--) {
		tempSum = Number(shorter.charAt(i)) + Number(longer.charAt(i)) + Number(remainder);
		result = (tempSum % 10) + result;
		if (tempSum > 9) {
			remainder = tempSum.toString().charAt(0);
		} else {
			remainder = '0';
		}
	}
	console.log(result);
}

input = [
	['155', '65'],
	['123456789', '123456789'],
	['887987345974539', '4582796427862587'],
	['347135713985789531798031509832579382573195807',
		'817651358763158761358796358971685973163314321'
	]
];
for (var arr in input) {
	sumTwoHugeNumbers(input[arr]);
}