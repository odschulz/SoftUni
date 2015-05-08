function solve(inputArr) {
	var allCourses = {};
	var sortedCourses;
	var output = {};
	for (var i = 0; i < inputArr.length; i++) {
		// var currentLine = inputArr[i].match(/([a-zA-Z]+\s[a-zA-Z]+)|([a-zA-Z]+\S)|(\d+\.\d+)|(\d+)/g);
		var currentLine = inputArr[i].split(/[\s]?\|[\s]?/g);
		var name = currentLine[0].trim();
		var course = currentLine[1].trim();
		var grade = Number(currentLine[2].trim());
		var visits = Number(currentLine[3].trim());

		if (!allCourses[course]) {
			allCourses[course] = {
				avgGrade: 0,
				avgVisits: 0,
				students: [],
				counter: 0
			};
		}
		allCourses[course].avgGrade += grade;
		allCourses[course].avgVisits += visits;
		if (allCourses[course].students.indexOf(name) < 0) {
    		allCourses[course].students.push(name);
		}
		allCourses[course].counter += 1;

	}
	for (var language in allCourses) {
		allCourses[language].avgGrade = Number((allCourses[language].avgGrade / allCourses[language].counter).toFixed(2));
		allCourses[language].avgVisits = Number((allCourses[language].avgVisits / allCourses[language].counter).toFixed(2));
		allCourses[language].students.sort();
		delete(allCourses[language].counter);
	}
	sortedCourses = Object.keys(allCourses).sort();
	for (i = 0; i < sortedCourses.length; i++) {
		output[sortedCourses[i]] = allCourses[sortedCourses[i]];
	}

	console.log(JSON.stringify(output));
}
input = [
	'Peter Nikolov | PHP  | 5.50 | 8',
	'Maria Ivanova | Java | 5.83 | 7',
	'Ivan Petrov   | PHP  | 3.00 | 2',
	'Ivan Petrov   | C#   | 3.00 | 2',
	'Peter Nikolov | C#   | 5.50 | 8',
	'Maria Ivanova | C#   | 5.83 | 7',
	'Ivan Petrov   | C#   | 4.12 | 5',
	'Ivan Petrov   | PHP  | 3.10 | 2',
	'Peter Nikolov | Java | 6.00 | 9'
];
solve(input);

// {"C#":{"avgGrade":4.61,"avgVisits":5.5,"students":["Ivan Petrov","Maria Ivanova","Peter Nikolov"]},
// "Java":{"avgGrade":5.92,"avgVisits":8,"students":["Maria Ivanova","Peter Nikolov"]},
// "PHP":{"avgGrade":3.87,"avgVisits":4,"students":["Ivan Petrov","Peter Nikolov"]}}
