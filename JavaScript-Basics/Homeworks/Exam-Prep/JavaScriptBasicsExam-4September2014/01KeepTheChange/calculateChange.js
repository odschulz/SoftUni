function solve(input) {
	var bill = Number(input[0]);
	var mood = input[1];
	if(mood === 'happy'){
		console.log(((10.0 / 100) * bill).toFixed(2));
	} else if(mood === 'married'){
		console.log(((0.05 / 100) * bill).toFixed(2));
	} else if(mood === 'drunk'){
		var tip = (15.0 / 100) * bill;
		var n = tip;
		while(n >= 10){
			n /= 10;

		}
		n = Math.floor(n);
		console.log(Math.pow(tip, n).toFixed(2));
	} else {
		console.log(((5.0 / 100) * bill).toFixed(2));
	}
}

var arr = [
	'120.44',
	'happy'
];
arr = [
'1230.83',
'drunk'
];

arr = [
'716.00',
'bored'
];

solve(arr);