function biggestRow(arr) {
	var newList;
	var maxValue = -Infinity;
	var tempValue;
	var output = [];
	for (var i = 2; i < arr.length - 1; i++) {
		tempValue = 0;
		newList = arr[i].replace(/<tr>|<td>|<\/tr>|<\/td>/g, '__').split('__').filter(Boolean);
		for (var j = 1; j < newList.length; j++) {
			if(!isNaN(Number(newList[j]))){
				tempValue += Number(newList[j]);
			}
		}
		if(tempValue > maxValue){
			output = [];
			maxValue = tempValue;
			for(var value in newList){
				if(!isNaN(Number(newList[value]))){
					output.push(newList[value]);
				}
			}
		}
	}
	if(output.join(' + ') === ''){
		console.log('no data');
	} else{
		console.log(maxValue + ' = ' + output.join(' + '));
	}
}

var input = [
	'<table>',
	'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
	'<tr><td>Sofia</td><td>12850</td><td>-560</td><td>20833</td></tr>',
	'<tr><td>Rousse</td><td>-</td><td>50000.0</td><td>-</td></tr>',
	'<tr><td>Bourgas</td><td>25000</td><td>25000</td><td>-</td></tr>',
	'</table>'
];

input = [
	'<table>',
	'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
	'<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>',
	'<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>',
	'<tr><td>Plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>',
	'<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>',
	'</table>'
];

// input = [
// 	'<table>',
// 	'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
// 	'<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
// 	'</table>',
// ];

biggestRow(input);
