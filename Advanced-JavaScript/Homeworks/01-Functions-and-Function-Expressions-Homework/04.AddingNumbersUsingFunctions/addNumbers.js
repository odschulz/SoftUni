function add(num) {
    function innerSum(increment) {
        return add(num + increment);
    }

    innerSum.toString = function () {
        return num;
    };

    return innerSum;
}

console.log(parseFloat(add(1)(1)(1)(1)(1))); // 5

console.log(parseFloat(add(1)(0)(-1)(-1))); // -1

var addTwo = add(2);
console.log(parseFloat(addTwo(3)(5))); // 10