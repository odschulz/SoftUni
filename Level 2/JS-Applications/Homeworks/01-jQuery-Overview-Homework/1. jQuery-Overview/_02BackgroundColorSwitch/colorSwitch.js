$(document).ready(function(){
	var paintButton = $('#paint-button'),
		className,
		color;

	paintButton.on('click', function() {
		className = $('#class-input').val();
		color = $('#color-input').val();
		$('.' + className).css('background-color', color);
	});
});