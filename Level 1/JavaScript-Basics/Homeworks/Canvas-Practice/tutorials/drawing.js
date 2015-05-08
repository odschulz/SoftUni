var my_pic = new Image();
my_pic.src  = "images/donger.png";
function draw () {
	var ctx = document.getElementById('canvas').getContext('2d');
	// ctx.drawImage(my_pic, x, y);
	// ctx.drawImage(my_pic, x, y, w, h);

	// ctx.drawImage(my_pic, 20, 20, 100, 100);

//TEXT

	// ctx.fillStyle = 'orange';
	// ctx.font = 'italic bold 56px Arial, sans-serif';
	// ctx.textAlign = 'start'; // start, end, left, right, center
	// ctx.fillText('Text On Canvas', 50, 50);
	// ctx.strokeText('Text On Canvas', 50, 50);

//SHADOWS

	ctx.fillRect(250, 250, 100, 100);

	ctx.fillStyle = 'orange';

	// shadowOffsetX or Y = positive or negative number
	// shadowBlur = positive number
	ctx.shadowColor = 'rgba(0, 0, 0, 0.3)';
	ctx.shadowOffsetX = 5;
	ctx.shadowOffsetY = -5;
	ctx.shadowBlur = 3;
	ctx.fillRect(50, 50, 100, 100);
}
window.onload = draw;
