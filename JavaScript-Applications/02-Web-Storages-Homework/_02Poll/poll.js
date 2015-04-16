/* I didn't have the time to make the timer :( */

$(document).ready(function(){

	if (localStorage.getItem('isSubmitted')) {
		showAnswersPage();
	} else {

		tickAnsweredQuestions();

		$('.answer').on('click', function() {
			localStorage.setItem($(this).parent().attr('id'), $(this).attr('id'));
		});

		$('#submit-button').on('click', function() {
			localStorage.setItem('isSubmitted', true);
			showAnswersPage();
		});
	}

	function tickAnsweredQuestions() {
		var answer;
		$('.questions').each(function() {

			answer = localStorage.getItem($(this).attr('id'));
			if (answer) {
				$(this).find('#' + answer).attr('checked', 'checked');
			}
		});
	}

	function showAnswersPage() {
		var answersPage = $('#answers-page'),
			questionName,
			answer,
			i;

		answersPage.html('');

		$('.questions').each(function() {
			questionName = $(this).find('.question-name').text();
			answerId = localStorage.getItem($(this).attr('id'));
			if (answerId) {
				answersPage.append($('<p>').text(questionName + ': ' + $('#' + answerId).attr('value')));
			} else {
				answersPage.append($('<p>').text(questionName + ': not answered'));
			}
		});

		$('#question-form').hide();
		answersPage.show();
	}
});