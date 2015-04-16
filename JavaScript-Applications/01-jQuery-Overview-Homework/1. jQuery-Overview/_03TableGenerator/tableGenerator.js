var models = {};

(function (scope) {
    function Table() {
        this._thead = $('<thead>').append('<tr>');
        this._tbody = $('<tbody>');
    }

    Table.prototype.addColumnTitles = function addColumnTitles(columnTitles) {
    	var headerRow,
    		columnTitleCell,
    		i,
    		title;

    	headerRow = this._thead.children(":first");

    	for (i = 0; i < columnTitles.length; i++) {
    		title = capitalizeFirstLetter(columnTitles[i]);

    		columnTitleCell = $('<th>').text(title);
    		headerRow.append(columnTitleCell);
    	}

    	function capitalizeFirstLetter(string) {
    		return string.charAt(0).toUpperCase() + string.slice(1);
		}
    };

    Table.prototype.addItem = function addItem(item) {
    	var row, cell;
    	row = $('<tr>');
    	for (var field in item) {
    		cell = $('<td>').text(item[field]);
    		row.append(cell);
    	}

    	this._tbody.append(row);
    };

    Table.prototype.getTableHtml = function getTableHtml() {
    	var table = $('<table>');
    	table.append(this._thead);
    	table.append(this._tbody);

    	return table;
    };

    scope.getTable = function getTable() {
        return new Table();
    };

})(models);

(function (scope) {
    function ParsedJSON(jsonString) {
    	this.objects = $.parseJSON(jsonString);
    }

    ParsedJSON.prototype.getObjectsKeysAsStrings = function getObjectsKeysAsStrings() {
		var keys = [],
			key,
			item,
			index,
			obj;

		/*
		This is in case the different JSON objects have different keys.
		It adds all unique keys to the keys array.
		*/
		for (index = 0; index < this.objects.length; index += 1) {
			obj = this.objects[index];
			for (item in Object.keys(obj)) {
				key = Object.keys(obj)[item];
				if (keys.indexOf(key) < 0) {
					keys.push(key);
				}
			}
		}

		return keys;
	};

    scope.getParsedJSON = function getParsedJSON(jsonString) {
        return new ParsedJSON(jsonString);
    };

})(models);

$(document).ready(function() {
	var jsonString,
		carTable,
		carsList,
		car;

	jsonString = '['
	+ '{"manufacturer":"BMW","model":"E92 320i","year":2011,"price":50000,"class":"Family"}'
	+ ', {"manufacturer":"Porsche","model":"Panamera","year":2012,"price":100000,"class":"Sport"}'
	+ ', {"manufacturer":"Peugeot","model":"305","year":1978,"price":1000,"class":"Family"}'
	+ ']';

	carsList = models.getParsedJSON(jsonString);

	carTable = models.getTable();

	carTable.addColumnTitles(carsList.getObjectsKeysAsStrings(carsList));

	for (car in carsList.objects) {
		carTable.addItem(carsList.objects[car]);
	}

	$("body").append(carTable.getTableHtml());

});