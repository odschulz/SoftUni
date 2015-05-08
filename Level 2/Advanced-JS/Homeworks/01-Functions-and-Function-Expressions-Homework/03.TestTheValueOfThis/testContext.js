//"use strict";

function testContext() {
    console.log(this);

}

console.log('Global scope:');
testContext();
console.log('***************************************************************');


function callFromAnotherFunc() {
    testContext.call(this);
}

console.log('From another function:');

callFromAnotherFunc();

/* In both cases, 'this' is the global object */

console.log('***************************************************************');

/* Called as an object */
var context = new testContext();
