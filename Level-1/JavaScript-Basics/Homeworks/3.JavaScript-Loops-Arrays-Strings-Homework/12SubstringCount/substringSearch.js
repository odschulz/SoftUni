function countSubstringOccur(arr) {
	var regexp = new RegExp(arr[0].toLowerCase(), 'g'),
		str = arr[1].toLowerCase();
	console.log(str.match(regexp).length);
}
var inputs = [
	['in', 'We are living in a yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.'],
	['your', 'No one heard a single word you said. They should have seen it in your eyes. What was going around your head.'],
	['but', 'But you were living in another world tryin\' to get your message through.']
];
countSubstringOccur(inputs[0]);
countSubstringOccur(inputs[1]);
countSubstringOccur(inputs[2]);