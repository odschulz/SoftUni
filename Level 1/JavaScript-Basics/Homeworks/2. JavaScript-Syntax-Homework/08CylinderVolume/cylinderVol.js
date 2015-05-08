function calcCylinderVol(arr) {
	var radius = arr[0],
		height = arr[1],
		volume = Math.PI * Math.pow(radius, 2) * height;
	console.log(volume.toFixed(3));

}
var cylinderValues = [
	[2, 4],
	[5, 8],
	[12, 3]
];
calcCylinderVol(cylinderValues[0]);
calcCylinderVol(cylinderValues[1]);
calcCylinderVol(cylinderValues[2]);