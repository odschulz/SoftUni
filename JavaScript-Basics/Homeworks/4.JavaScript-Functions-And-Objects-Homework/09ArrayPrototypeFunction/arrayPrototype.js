Array.prototype.removeItem = function() {
	for (var item in arguments) { // this way I can remove items with different values at once. Try it with arr.removeItem(1, 4);
		for (var i = 0; i < this.length; i++) {
			if (this[i] === arguments[item]) {
				this.splice(i, 1);
			}
		}
	}
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr.removeItem(1);
console.log(arr);
arr = ['hi', 'bye', 'hello'];
arr.removeItem('bye');
console.log(arr);