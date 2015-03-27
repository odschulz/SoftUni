function calcExpression() {
	if (document.getElementById('input-text').value === '') {
		document.getElementById('result-field').innerHTML = 'Enter an expression';
	} else {
		var input = document.getElementById('input-text').value.replace(/[^0-9 '\-' '\+' '\/' '\*' '\.' '\(' '\)']+/g, "");
		document.getElementById('result-field').innerHTML = eval(input);
	}
}