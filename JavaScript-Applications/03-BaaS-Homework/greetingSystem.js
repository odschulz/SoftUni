


/* No time to finish it :( */

$(document).ready(function(){
	var headers = {
		'X-Parse-Application-Id': 'kl7AMer8bvLltNtOBIAIuhjhukOJQYB3ZXVOoY59',
		'X-Parse-REST-API-Key': 'up6TjuZGGdIJSEYvltjAk6qYXG6DAmG16Ti0AjIO'
		};

	getCountries();

	function getCountries(argument) {
		$.ajax({
			url: 'https://api.parse.com/1/classes/Country/',
			method: 'GET',
			headers: headers
		}).success(function (data) {
			var countryId;
			loadCountries(data);

			if ($('#countries-selector option:selected').val() == 'all') {
				countryId = 'all';
			} else {
				countryId = $('#countries-selector option:selected').data('country');
			}

			getTowns(countryId);
		}).error(function (err) {
			console.log(err);
		});
	}

	function getTowns(countryId) {
		var url = 'https://api.parse.com/1/classes/Town/';

		$.ajax({
			url: url,
			method: 'GET',
			headers: headers
		}).success(function (data) {
			loadTownsForCountry(data);
		}).error(function (err) {
			console.log(err);
		});
	}

	function loadCountries(data) {
		var countries = data.results;
		$('#countries-selector').append($('<option>').val('all').text('all'));
		for (var country in countries) {
			var countryOption = $('<option>')
				.val(countries[country].name)
				.text(countries[country].name);

			$(countryOption).data('country', countries[country].objectId);

			$('#countries-selector').append(countryOption);
		}
	}

	function loadTownsForCountry(data) {
		var towns = data.results,
			townsContainer = $('#towns');
		townsContainer.html('');
		for (var town in towns) {
			townsContainer.append($('<p>').text(towns[town].name));
		}
	}
	$('#countries-selector').change(function () {
		console.log('Country id: ' + $('#countries-selector option:selected').data('country'));
		getTowns($('#countries-selector option:selected').data('country'));
	});

});