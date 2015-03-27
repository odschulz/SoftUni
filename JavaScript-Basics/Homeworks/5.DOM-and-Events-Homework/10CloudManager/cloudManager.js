function solve(input) {
	var allFiles = {};
	for (var i = 0; i < input.length; i++) {
		var currentLine = input[i].split(' ');
		var file = currentLine[0].trim();
		var extension = currentLine[1].trim();
		var size = Number(currentLine[2].trim().match(/\d+\.*\d*/g));
		if(!allFiles[extension]){
			allFiles[extension] = {
				files: [],
				memory: 0
			};
		}
		if (allFiles[extension].files.indexOf(file) < 0) {
			allFiles[extension].files.push(file);
		}
		allFiles[extension].memory += size;
	}

	allFiles = sortObject(allFiles);
	for(var ext in allFiles){
		allFiles[ext].files.sort();
		allFiles[ext].memory = allFiles[ext].memory.toFixed(2);
	}
	console.log(JSON.stringify(allFiles));

	function sortObject(obj) {
        var sortedKeys = Object.keys(obj).sort();
        var sortedObj = {};
        for (var i = 0; i < sortedKeys.length; i++) {
            var key = sortedKeys[i];
            sortedObj[key] = obj[key];
        }
        return sortedObj;
    }
}

var arr = [
	'sentinel .exe 15MB',
	'zoomIt .msi 3MB',
	'skype .exe 45MB',
	'trojanStopper .bat 23MB',
	'kindleInstaller .exe 120MB',
	'setup .msi 33.4MB',
	'winBlock .bat 1MB'
];

solve(arr);