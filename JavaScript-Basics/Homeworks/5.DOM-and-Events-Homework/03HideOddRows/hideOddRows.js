var button = document.getElementById("btnHideOddRows");
button.onclick = function () {
var oddRows = document.body.querySelectorAll("tr:nth-child(odd)");
	for (var i = 0, len = oddRows.length; i < len; i++) {
    oddRows[i].style.display = "none";
	}
};