function findYoungestPerson(persons) {
	var youngestPerson, youngestAge = Number.MAX_VALUE;
	for (var person in persons) {
		if (persons[person].age && persons[person].age < youngestAge) {	//check if key 'age' exists and if it is > 0
			youngestAge = persons[person].age;
			youngestPerson = persons[person].firstname + ' ' + persons[person].lastname;
		}
	}
	console.log('The youngest person is ' + youngestPerson);
}

var persons = [
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 40}
];

findYoungestPerson(persons);