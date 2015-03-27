
var feathers = new Image();
feathers.src = "images/feathers.png";
function draw() {
	var ctx = document.getElementById("canvas").getContext("2d");
	// alert(ctx.canvas.id+" | "+ctx.canvas.width+" | "+ctx.canvas.height);

	// var g1 = ctx.createLinearGradient(0, 0, 200, 0);
	// g1.addColorStop(0, "magenta");
	// g1.addColorStop(0.5, "yellow");
	// g1.addColorStop(1, "black");
	// ctx.fillStyle = g1;
	// ctx.strokeStyle = "red";
	// ctx.lineWidth = 10;
	// ctx.fillRect(0, 0, 200, 200);
	// ctx.strokeRect(0, 0, 200, 200);
	// // ctx.clearRect(0, 0, 100, 100);

	// // var g2 = ctx.createRadialGradient(x0, y0, r0, x1, y1, r1,);
	// var g2 = ctx.createRadialGradient(350, 100, 0, 350, 100, 200);
	// g2.addColorStop(0, "magenta");
	// g2.addColorStop(0.5, "yellow");
	// g2.addColorStop(1, "black");
	// ctx.fillStyle = g2;
	// ctx.strokeStyle = "green";
	// ctx.fillRect(250, 0, 200, 200);
	// ctx.strokeRect(250, 0, 200, 200);

//*********************************************************
	// var pattern = ctx.createPattern(feathers, "repeat");
	// ctx.fillStyle = pattern;
	// ctx.fillRect(0, 250, 200, 200);
	// ctx.lineWidth = 20;
	// ctx.strokeStyle = g1;
	// ctx.strokeRect(0, 250, 200, 200);
	// ctx.fill();

//****************************************************
	// ctx.lineWidth = 20;
	// ctx.lineCap = "round"; // butt, round, square (ends of lines)
	// ctx.lineJoin = "miter"; // bevel, round, miter (where they join)
	// ctx.miterLimit = 3;
	// ctx.setLineDash([20]);
	// ctx.lineDashOffset = 185; // creates an ant-like effect

	// ctx.beginPath();
	// ctx.moveTo(150, 150);
	// ctx.lineTo(240, 240);
	// ctx.lineTo(300, 40);
	// ctx.stroke();

//*******************************************************
// //Making a rectang with path and checking if a point is in

// 	ctx.beginPath(); // Resets the current default path
// 	ctx.moveTo(50, 50);  // Creates a new subpath with the given point
// 	ctx.lineTo(250, 50); // Creates a new line along the current subpath
// 	ctx.lineTo(250, 150);
// 	ctx.lineTo(50, 150);
// 	ctx.fill();
// 	ctx.closePath();
// 	ctx.stroke(); // Strokes the current default path
// 	alert(ctx.isPointInPath(75, 75)); // Determines whether a point with these coord is in the path
// // needs either a stroke or a fill to be displayed.

//**********************************************************
// CLIP 1 figure with another

// ctx.rect(50, 50, 100, 100);
// ctx.clip();
// ctx.rect(0, 0, 100, 100);
// ctx.stroke();

//Make Circle
//ctx.arc(x, y, radius, startAngle, endAngle, anticlockwise);

// ctx.arc(150, 150, 100, 0, Math.PI*2, false);
// ctx.stroke();

//arcTo
//ctx.arcTo(x1, y1, x2, y2, radius);

// ctx.moveTo(50, 50);
// ctx.lineTo(300, 50);
// ctx.arcTo(350, 50, 350, 100, 50);
// ctx.lineTo(350, 200);
// ctx.stroke();

//quadraticCurveTo
//ctx.quadraticCurveTo(cpx, cpy, x, y);

// ctx.moveTo(50, 50);
// ctx.lineTo(300, 50);
// ctx.quadraticCurveTo(300, 100, 390, 100);
// ctx.lineTo(390, 200);
// ctx.stroke();

//bezierCurveTo
//ctx.bezierCurveTo(cp1x, cp1y, cp2x, cp2y, x, y);

// ctx.moveTo(50, 50);
// ctx.lineTo(300, 50);
// ctx.bezierCurveTo(200, 100, 120, 140, 390, 100);
// ctx.lineTo(390, 200);
// ctx.stroke();
}
window.onload = draw;