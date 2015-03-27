String.prototype.startsWith = function (substring) {

    var substringLength = substring.length,
        thisLength = this.length,
        i;

    if (substringLength > thisLength) {
        return false;
    }

    for (i = 0; i < substringLength; i += 1) {
        if (this[i] !== substring[i]) {
            return false;
        }
    }

    return true;
};

String.prototype.endsWith = function (substring) {

    var substringLength = substring.length,
        thisLength = this.length,
        stringPosition = thisLength - substringLength,
        subStringPosition = 0;

    if (stringPosition < 0) {
        return false;
    }

    while (this[stringPosition]) {
        if (this[stringPosition] !== substring[subStringPosition]) {
            return false;
        }
        stringPosition += 1;
        subStringPosition += 1;
    }

    return true;
};

String.prototype.left = function (count) {
    return this.substring(0, count);
};

String.prototype.right = function (count) {
    var strLength = this.length;
    var substrStart = strLength - count;
    if (count > strLength) {
        return this.toString();
    }

    return this.substring(substrStart);
};

String.prototype.padLeft = function (count, ch) {
    var character = ch || ' ';

    return character.repeat(count) + this;
};

String.prototype.padRight = function (count, ch) {
    var character = ch || ' ';

    return this + character.repeat(count);
};

String.prototype.repeat = function (count) {
    return new Array(count + 1).join(this);
};

var str = 'abc';
console.log('My string: ' + str);
console.log('*'.repeat(40));

console.log('Starts with ab: ' + str.startsWith('ab'));
console.log('Ends with bc: ' +str.endsWith('bc'));
console.log('Left 2 chars: ' + str.left(2));
console.log('Right 2 chars: ' + str.right(2));
console.log('Padleft without specified character:' + str.padLeft(5));
console.log('Padright with specified character: ' + str.padRight(5, '*'));

console.log('*'.repeat(40));
console.log('My original string again:' + str);












