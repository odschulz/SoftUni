$(document).ready(function(){
	var totalVisits,
		totalVisitsP,
		sessionVisits;

	if (!localStorage.getItem('visitsCount')) {
		localStorage.setItem('visitsCount', 0);
	}

	if (!sessionStorage.getItem('visitsCount')) {
		sessionStorage.setItem('visitsCount', 0);
	}

	localStorage.visitsCount ++;
	sessionStorage.visitsCount ++;

	totalVisits = localStorage.getItem('visitsCount');
	sessionVisits = sessionStorage.getItem('visitsCount');

	$('#total-visits').text('Total visits: ' + totalVisits);
	$('#session-visits').text('Current session visits: ' + sessionVisits);

	$('#clear-localStorage').on('click', function() {
		localStorage.clear();
	});

	$('#clear-sessionStorage').on('click', function() {
		sessionStorage.clear();
	});

	$('#clear-both').on('click', function() {
		localStorage.clear();
		sessionStorage.clear();
	});

	if (localStorage.getItem('name')) {
		var section = $('<section>')
			.append($('<p>')
			.text('Hello ' + localStorage.getItem('name') + '!'));
		$('#login-form').remove();
		$('body').append(section);


	} else {
		var form = $('<form id="login-form">');
		var usernameInput = $('<input id="username-input" type="text" placeholder="Username">');
		var submitButton = $('<button>').text('submit');
		submitButton.on('click', saveUsernameToLocalStorage);

		form.append(usernameInput).append(submitButton);
		$("body").append(form);
	}

	function saveUsernameToLocalStorage(argument) {
		if ($('#username-input').val()) {
			localStorage.setItem('name', $('#username-input').val());
		}
	}
});