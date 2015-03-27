function compareObjects(obj, objCopy) {
	return obj == objCopy;
}

function clone(obj) {
	return JSON.parse(JSON.stringify(obj));
}


var a = {
	name: 'Pesho',
	age: 21
}
var b = clone(a);
console.log('a == b --> ' + compareObjects(a, b));
b = a;
console.log('a == b --> ' + compareObjects(a, b));