function displayProperties() {
	var propertyArr = [];
	for (var property in document) {
		propertyArr.push(property.toLowerCase());
	}
	propertyArr.sort();
	for (var key in propertyArr) {
		console.log(propertyArr[key]);
	}
	document.getElementById('output').innerHTML = propertyArr.join('</br>');
}

displayProperties();