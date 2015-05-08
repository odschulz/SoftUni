function autocomplete(arr) {
	var inputWords = arr[0].split(' ');
	var output = [];
	for (var i = 1; i < arr.length; i++) {
		var tempArr = [];
		for (var j = 0; j < inputWords.length; j++) {
			if (inputWords[j].substring(0, arr[i].length) == arr[i]) {
				tempArr.push(inputWords[j]);
			}
		}
		if (tempArr.length === 0) {
			console.log('-');
				continue;
			}

		tempArr.sort(function(a, b) {
			return a.length - b.length;
		});

		for (var temp in tempArr) {
			if (tempArr[temp].length > tempArr[0].length) {
				delete(tempArr[temp]);
			}
		}

		tempArr = tempArr.filter(function(v) {
				return v !== '';
		});

		if (tempArr.length === 1) {
			output.push(tempArr[0]);
			continue;
		} else {
			var smallest = tempArr[0];
			for (var t = 0; t < tempArr.length; t++) {

				if(smallest.charAt(arr[i].length) > tempArr[t].charAt(arr[i].length)){
					smallest = tempArr[t];
				}
			}
			output.push(smallest);
		}

	}
	for (var word in output) {
		console.log(output[word]);
	}
}


var input = [
	'word screammm screech speech wolf',
	'bas',
	'wo',
	'scr',
	's'
];

autocomplete(input);