function findMostFreqWord(str) {

    var faces = str.replace(/[^a-zA-Z0-9 ]/g, "").split(' ');
    var faceCount = {}, 
    frequency;
    for (var i = 0; i < faces.length; i++) {
        faceCount[faces[i]] = (faceCount[faces[i]] || 0) + 1;
    }

    for (i = 0; i < faces.length; i++) {
        if(faces[i] in faceCount){
            frequency = (faceCount[faces[i]] / faces.length) * 100;
            console.log(faces[i] + ' -> ' + frequency.toFixed(2) + '%');
            delete(faceCount[faces[i]]);
        }
    }
}
var inputs = [
    '8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦', 
    'J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠', 
    '10♣ 10♥'
];
findMostFreqWord(inputs[0]);
console.log();
findMostFreqWord(inputs[1]);
console.log();
findMostFreqWord(inputs[2]);
console.log();