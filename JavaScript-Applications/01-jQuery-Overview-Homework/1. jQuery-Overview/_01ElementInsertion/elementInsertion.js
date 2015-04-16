function addBefore() {
	var beforeElement = $('<div></div>').css('background', 'purple').text('Before Element');
	$('#modifiable').before(beforeElement);
}

function addAfter() {
	var afterElement = $('<div></div>').css('background', 'tomato').text('After Element');
	$('#modifiable').after(afterElement);
}