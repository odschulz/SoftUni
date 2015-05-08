function mouseOver() {
    this.getElementsByClassName('tooltip')[0].style.visibility = 'visible';

}

function mouseMove() {
    this.getElementsByClassName('tooltip')[0].style.left= event.pageX + 15 + 'px';
    this.getElementsByClassName('tooltip')[0].style.top= event.pageY + 15 + 'px';
}

function mouseOut() {
    this.getElementsByTagName('div')[0].style.visibility = 'hidden';
}

var seminars = document.getElementsByClassName("seminar");

for(var i = 0; i < seminars.length ; i++){
    seminars[i].addEventListener('mouseover', mouseOver);
    seminars[i].addEventListener('mousemove', mouseMove);
    seminars[i].addEventListener('mouseout', mouseOut);
}



