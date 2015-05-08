function treeHouseCompare(arr) {
	var a = arr[0],
		b = arr[1],
		houseArea = Math.pow(a, 2) + (Math.pow(a, 2) / 3),
		treeArea = b * (b / 3) + Math.PI * Math.pow((2 / 3 * b), 2);
	console.log(Math.max(houseArea, treeArea).toFixed(2));
}
var inputValues = [
	[3, 2],
	[3, 3],
	[4, 5]
];
treeHouseCompare(inputValues[0]);
treeHouseCompare(inputValues[1]);
treeHouseCompare(inputValues[2]);