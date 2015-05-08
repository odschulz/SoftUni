function compareChars(arr1, arr2) {
	var str = 'Equal';
	if (arr1.length != arr2.length) {
		str = 'Not Equal';
	} else {
		for (var i = 0; i < arr1.length; i++) {
			if (arr1[i] != arr2[i]) {
				str = 'Not Equal';
				break;
			}
		}
	}
	console.log(str);
}
var inputs = {
	input1: [
		['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'],
		['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']
	],
	input2: [
		['3', '5', 'g', 'd'],
		['5', '3', 'g', 'd']
	],
	input3: [
		['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'],
		['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']
	]
};
compareChars(inputs.input1[0], inputs.input1[1]);
compareChars(inputs.input2[0], inputs.input2[1]);
compareChars(inputs.input3[0], inputs.input3[1]);