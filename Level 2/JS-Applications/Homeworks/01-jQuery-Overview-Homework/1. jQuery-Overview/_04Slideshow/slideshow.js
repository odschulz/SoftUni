
/* Unfortunatelly, I don't have the time to make this better and more readable :( */

$(document).ready(function() {
    var slides = [],
        slideCount = 15,
        slideContainer = $('#slide-container'),
        leftButton = $('#button-left'),
        rightButton = $('#button-right'),
        activeSlide,
        slideToActivate,
        colors = ['red', 'yellow', 'green', 'blue', 'tomato', 'magenta', 'orange', 'brown'],
        colorIndex,
        i,
        elementToAdd;

    /* This populates the slide-container with slides and gives them different colors.
    *  Change the slideCount variable for different amount of slides.
    */
    for (i = 0, colorIndex = 0; i < slideCount; i += 1, colorIndex += 1) {
        elementToAdd = $('<div class="inactive-slide">');

        if (colorIndex >= colors.length) {
            colorIndex = 0;
        }

        elementToAdd.css('background-color', colors[colorIndex]);
        slides[i] = elementToAdd;
        slideContainer.append(slides[i]);
    }

    /* Check if there are any slides*/
    if (slideCount > 0) {
        slides[0].attr('class', 'active-slide');

        leftButton.on('click', leftClick);
        rightButton.on('click', rightClick);
    }

    function leftClick () {
        activeSlide = slides.filter(function (slide) {
            return slide.attr('class') == 'active-slide';
        })[0];

        if (slides.indexOf(activeSlide) > 0) {
            slideToActivate = activeSlide.prev('.inactive-slide');
        } else {
            slideToActivate = slides[slides.length - 1];
        }

        activeSlide.attr('class', 'inactive-slide');
        slideToActivate.attr('class', 'active-slide');
        setInterval(function() { leftClick(); }, 5000);
    }

    function rightClick () {
        activeSlide = slides.filter(function (slide) {
            return slide.attr('class') == 'active-slide';
        })[0];

        if (slides.indexOf(activeSlide) < (slides.length - 1)) {
            slideToActivate = activeSlide.next('.inactive-slide');
        } else {
            slideToActivate = slides[0];
        }

        activeSlide.attr('class', 'inactive-slide');
        slideToActivate.attr('class', 'active-slide');
        setInterval(function() { rightClick(); }, 5000);
    }
});