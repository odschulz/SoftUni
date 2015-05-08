var count = {};

function addItem(div, field) {  
	if (!count[div]) {
		count[div] = 0;
		count[field] = 0;
	}
	var referenceNode = document.getElementsByClassName(div)[count[div]];
	var newNode = referenceNode.cloneNode(true);
	referenceNode.parentNode.insertBefore(newNode, referenceNode.nextSibling);
	count[div] +=1;
	count[field] +=1;
	document.getElementsByClassName(field)[count[field]].value = '';
}

function removeItem(div, field) {
	if (count[div] > 0) {
		var removeThis = document.getElementsByClassName(div)[count[div]];
		removeThis.parentNode.removeChild(removeThis);
		count[div] -=1;
		count[field] -=1;
	}
}