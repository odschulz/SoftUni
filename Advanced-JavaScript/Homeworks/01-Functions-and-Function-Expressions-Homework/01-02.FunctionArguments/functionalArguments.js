function printArgsInfo() {
    var i;
    for (i = 0; i < arguments.length; i++) {
        console.log(arguments[i] + "(" + typeof(arguments[i]) + ")");
    }
}

printArgsInfo(2, 3, 2.5, -110.5564, false);
console.log();

printArgsInfo(null, undefined, "", 0, [], {});
console.log();

printArgsInfo([1, 2], ["string", "array"], ["single value"]);
console.log();

printArgsInfo("some string", [1, 2], ["string", "array"], ["mixed", 2, false, "array"], {name: "Peter", age: 20});
console.log();

printArgsInfo([[1, [2, [3, [4, 5]]]], ["string", "array"]]);
console.log();

printArgsInfo.call();

printArgsInfo.call(null,[[1, [2, [3, [4, 5]]]], ["string", "array"]]);

console.log();

printArgsInfo.apply();

printArgsInfo.apply(null,[[1, [2, [3, [4, 5]]]], ["string", "array"]]);