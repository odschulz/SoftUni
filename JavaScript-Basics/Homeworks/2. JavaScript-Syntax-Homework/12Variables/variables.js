function variablesTypes(arr) {
	var name = arr[0],
		age = arr[1],
		isMale = arr[2],
		favoriteFoods = arr[3];
	console.log('\"My name: ' + name + ' //type is ' + typeof(name) +
		'\nMy age: ' + age + ' //type is ' + typeof(age) +
		'\nI am male: ' + isMale + ' //type is ' + typeof(isMale) +
		'\nMy favorite foods are: ' + favoriteFoods + ' //type is ' + typeof(favoriteFoods) + '\"');
}
var inputVariables = [
	'Pesho', 22, true, ['fries', 'banana', 'cake']
];
variablesTypes(inputVariables);