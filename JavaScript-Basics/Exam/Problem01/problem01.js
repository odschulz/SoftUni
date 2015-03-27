function solve(input) {
	var fan = {date: -Infinity, counter: 0};
	var hater = {date: +Infinity, counter: 0};
	var border = new Date(1973, 06, 25);
	var lowDate = new Date(1900, 0, 01);
	var highDate = new Date(2015, 0, 01);
	for (var i = 0; i < input.length; i++) {
		var currentLine = input[i].split('.');
		var tempDate = new Date(Number(currentLine[2].trim()), Number(currentLine[1].trim()) - 1, Number(currentLine[0].trim()));
		if ((tempDate <= lowDate) || tempDate >= highDate) {
			continue;
		}
		if (tempDate <= border) {
			hater.counter += 1;
			if(tempDate < hater.date){
				hater.date = tempDate;
				hater.output = 'The biggest hater of ewoks was born on ' + hater.date.toDateString();
			}
		} else {
			fan.counter += 1;
			if(tempDate > fan.date){
				fan.date = tempDate;
				fan.output = 'The biggest fan of ewoks was born on ' + fan.date.toDateString();
			}
		}
	}
	if (fan.counter === 0 && hater.counter === 0) {
			console.log('No result');
		}
		if (fan.counter > 0) {
			console.log(fan.output);
		}
		if(hater.counter > 0){
			console.log(hater.output);
		}
}
var arr = [
	'17.12.1933'
];

arr = [
	'01.01.1900',
	'01.01.2015'
];

solve(arr);