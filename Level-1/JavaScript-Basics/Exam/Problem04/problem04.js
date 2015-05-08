function solve(input) {
	conditions = input[0].split('^');
	var studentCond = conditions[0].trim();
	var trainerCond = conditions[1].trim();
	var output = {
		students: [],
		trainers: []
	};
	for (var i = 1; i < input.length; i++) {
		var obj;
		if (input[i].indexOf('student') > -1) {
			obj = JSON.parse(input[i]);
			output.students.push(obj);
		} else if (input[i].indexOf('trainer') > -1) {
			obj = JSON.parse(input[i]);
			output.trainers.push(obj);
		}
	}

	function sortObject(obj) {
        var sortedKeys = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < sortedKeys.length; i++) {
            var key = sortedKeys[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
    console.log(JSON.stringify(output));
}

var arr = [
	'level^courses',
	'{"id":0,"firstname":"Angel","lastname":"Ivanov","town":"Plovdiv","role":"student","grades":["5.89"],"level":2,"certificate":false}',
	'{"id":1,"firstname":"Mitko","lastname":"Nakova","town":"Dimitrovgrad","role":"trainer","courses":["PHP","Unity Basics"],"lecturesPerDay":6}',
	'{"id":2,"firstname":"Bobi","lastname":"Georgiev","town":"Varna","role":"student","grades":["5.59","3.50","4.54","5.05","3.45"],"level":4,"certificate":false}',
	'{"id":3,"firstname":"Ivan","lastname":"Ivanova","town":"Vidin","role":"trainer","courses":["JS","Java","JS OOP","Database","OOP","C#"],"lecturesPerDay":7}',
	'{"id":4,"firstname":"Mitko","lastname":"Petrova","town":"Sofia","role":"trainer","courses":["Database","JS Apps","Java"],"lecturesPerDay":2}'
];

solve(arr);