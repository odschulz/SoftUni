function findMostFreqWord(str) {

    str = str.toLowerCase().replace(/[\.,-\/#!$%\^&\*;:{}=\-_`~()]/g, "").split(' ');

    var wordCounts = {};
    for (var i = 0; i < str.length; i++) {
        wordCounts[str[i]] = (wordCounts[str[i]] || 0) + 1;
    }
    var arr = [];
    for (var word in wordCounts) {
        if (wordCounts.hasOwnProperty(word)) {
            arr.push({
                'key': word,
                'value': wordCounts[word]
            });
        }
    }
    arr.sort(function(a, b) {
        return b.value - a.value;
    });
    for (var obj in arr) {
        if (arr[obj].value < arr[0].value) {
            delete(arr[obj]);
        } else {
            console.log(arr[obj].key + ' -> ' + arr[obj].value + ' times');
        }
    }
}
var inputs = [
    'in the middle of the night', 
    'Welcome to SoftUni. Welcome to Java. Welcome everyone.', 
    'Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.'
];
findMostFreqWord(inputs[0]);
console.log();
findMostFreqWord(inputs[1]);
console.log();
findMostFreqWord(inputs[2]);
console.log();