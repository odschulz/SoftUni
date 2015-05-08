var canvas,
	ctx,
	cWidth,
	cHeight;
var pic = new Image();
pic.src = 'kappa.png';

// function draw() {

// }

var x = 0;
var y = 0;

function animate() {
	ctx.save();
	clear();


	ctx.fillStyle = 'green';
	ctx.fillRect(x, y, 100, 100);



	ctx.restore();
	window.requestAnimationFrame(animate);
}



function drawImage() {
	ctx.drawImage(pic, 0, 0, 20, 20, 10, 10, 90, 90); // x y to cut from(xy from image, not canvas), 
	// xy to cut to, xy to start from, xy for size
}

function squares() {
	for (var col = 0; col < 10; col++) {
		for (var row = 0; row < 8; row++) {
			ctx.fillStyle = randomColor();
			ctx.fillRect(60 * col + 10, 10 * row + 10, 50, 50);
		}
	}
}

function randomColor() {
	var redRandom = Math.floor(Math.random() * 255);
	var greenRandom = Math.floor(Math.random() * 255);
	var blueRandom = Math.floor(Math.random() * 255);

	return 'rgb(' + redRandom + ', ' +
		greenRandom + ', ' +
		blueRandom + ')';
}

function clear() {
	ctx.clearRect(0, 0, cWidth, cHeight);
}

function init() {
	canvas = document.getElementById('canvas');
	ctx = canvas.getContext('2d');
	cWidth = canvas.width;
	cHeight = canvas.height;

	// draw();
	animate();


}

document.addEventListener('keydown', function(event) {
	var keyCode = event.keyCode;
	if (keyCode == 39) { //right
		x += 1;
	} else if (keyCode == 37) { //left
		x -= 1;
	} else if (keyCode == 38) { //up
		y -= 1;
	} else if (keyCode == 40) { //down
		y += 1;
	}
});



window.addEventListener('load', init);