function getPriceTrend(arr) {
	var fixed = '</td><td><img src=\"fixed.png\"/></td></td>';
	var up = '</td><td><img src=\"up.png\"/></td></td>';
	var down = '</td><td><img src=\"down.png\"/></td></td>';
	var prefix = '<tr><td>';
	console.log('<table>\n<tr><th>Price</th><th>Trend</th></tr>');
	console.log(prefix + parseFloat(arr[0]).toFixed(2) + fixed);
	for (var i = 1; i < arr.length; i++) {
		var current = parseFloat((parseFloat(arr[i])).toFixed(2));
		var previous = parseFloat((parseFloat(arr[i - 1])).toFixed(2));
		if (current > previous) {
			console.log(prefix + current.toFixed(2) + up);
		} else if (current < previous) {
			console.log(prefix + current.toFixed(2) + down);
		} else if (current === previous){
			console.log(prefix + current.toFixed(2) + fixed);
		}
	}
	console.log('</table>');
}
input = [
	'36.333',
	'36.5',
	'37.019',
	'35.4',
	'35',
	'35.001',
	'36.225'
];

getPriceTrend(input);