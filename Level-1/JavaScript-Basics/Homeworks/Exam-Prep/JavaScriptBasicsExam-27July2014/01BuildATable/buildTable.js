function solve(arr) {
	start = Number(arr[0]);
	end = Number(arr[1]);
	console.log('<table>\n<tr><th>Num<\/th><th>Square<\/th><th>Fib<\/th><\/tr>');
	for (var i = start; i <= end; i++) {
		var current = i;
		console.log('<tr><td>' + current + '<\/td><td>' + Math.pow(current, 2) + '<\/td><td>' + isFib(current) + '<\/td><\/tr>');
	}
	console.log('<\/table>');
	function isFib(num) {
		if(num <= 2){
			return 'yes';
		}
		var previous = 1;
		var current = 2;
		while(current <= num){
			current = previous + current;
			previous = current - previous;
			if(current === num){
				return 'yes';
			}
		}
		return 'no';
	}
}

var input = [1, 2];
input = [55, 56];
solve(input);


