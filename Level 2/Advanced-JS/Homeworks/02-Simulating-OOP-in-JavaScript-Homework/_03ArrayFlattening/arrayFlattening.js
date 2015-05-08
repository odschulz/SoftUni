Array.prototype.flatten = function () {
    var flattenedArray = [];

    function copyArray(arr) {
        for (var i = 0; i < arr.length; i += 1) {
            if (arr[i] instanceof Array) {
                copyArray(arr[i]);
            } else {
                flattenedArray.push(arr[i]);
            }
        }
    }

    copyArray(this);

    return flattenedArray;
};

var arr1 = [1, 2, [3, 4], 5];
console.log('Original:');
console.log(arr1);
console.log();
console.log('Flattened:');
console.log(arr1.flatten());
