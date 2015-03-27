function solve(input) {
	var allConcerts = {};
	var sortedConcerts;
	var sortedVenues;
	var output = {};
	for (var i = 0; i < input.length; i++) {
		var currentLine = input[i].split(/[\s]?\|[\s]?/g);
		var band = currentLine[0].trim();
		var city = currentLine[1].trim();
		var date = currentLine[2].trim();
		var venue = currentLine[3].trim();
		if (!allConcerts[city]) {
			allConcerts[city] = {};
		}
		if (!allConcerts[city][venue]) {
			allConcerts[city][venue] = [];
		}
		if (allConcerts[city][venue].indexOf(band) < 0) {
			allConcerts[city][venue].push(band);
		}
	}

	allConcerts = sortObject(allConcerts);
    for (var town in allConcerts) {
        allConcerts[town] = sortObject(allConcerts[town]);
        for (var venues in allConcerts[town]) {
            allConcerts[town][venues].sort();
        }
    }
    
    console.log(JSON.stringify(allConcerts));

    function sortObject(obj) {
        var sortedKeys = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < sortedKeys.length; i++) {
            var key = sortedKeys[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
}

arr = [
	'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
	'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
	'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
	'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
	'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
	'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
	'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
	'Helloween | London | 28-Jul-2014 | Wembley Stadium',
	'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
	'Metallica | London | 03-Oct-2014 | Olympic Stadium',
	'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
	'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
];

solve(arr);