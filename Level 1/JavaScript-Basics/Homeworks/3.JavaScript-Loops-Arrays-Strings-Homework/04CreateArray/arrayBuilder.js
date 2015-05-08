function createArray() {
	var arr = [],
		counter = 0;
	for (var i = 0; i < 20; i++) {
		arr[i] = i * 5;
		counter++;
	}
	console.log(arr.join(' '));
	// the sample output in the homework description has 21 integers 
	// so I put a counter to show that 20 integers were printed here
	console.log(counter + ' integers printed!');
}
createArray();