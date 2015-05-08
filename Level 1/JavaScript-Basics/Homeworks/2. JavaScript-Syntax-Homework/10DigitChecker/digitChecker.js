function checkDigit(number) {
	var thirdDigit = number.toString().split('').reverse().join('').charAt(2);
	// var thirdDigit = number.toString().charAt(number.toString().length - 3);  // another way
	var isThree = parseInt(thirdDigit) === 3;
	console.log(isThree);
}
checkDigit(1235);
checkDigit(25368);
checkDigit(123456);