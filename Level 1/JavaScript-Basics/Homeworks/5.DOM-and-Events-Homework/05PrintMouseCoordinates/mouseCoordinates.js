function coordinates() {
    var x = event.clientX;
    var y = event.clientY;
    var outputContent = output.innerHTML;
    output.innerHTML = 'X:' + x + '; Y:' + y + '; Time: ' + new Date() + '\n' + outputContent;
}
var output = document.getElementById('output');
document.addEventListener('mousemove', coordinates);