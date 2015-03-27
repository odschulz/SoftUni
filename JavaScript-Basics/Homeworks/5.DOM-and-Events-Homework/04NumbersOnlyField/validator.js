function validate() {
    var inputValue = input.value;
    var forbiddenChars = /\D/g;
    if (forbiddenChars.test(inputValue)) {
    	input.value = inputValue.slice(0, inputValue.length - 1);
        input.style.background = 'red';
        setTimeout(function() {
        	input.style.background = 'white';
        }, 500);
    }
}

var input = document.getElementById('input');
input.addEventListener('input', validate);