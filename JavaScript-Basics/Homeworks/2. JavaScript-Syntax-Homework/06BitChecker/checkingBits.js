function bitChecker(number) {
	var isSet = ((number >> 3) & 1) !== 0;
	console.log(isSet);
}
bitChecker(333);
bitChecker(425);
bitChecker(2567564754);