var app = app || {};

app.requester = (function() {
    function Requester() {
    }

    Requester.prototype.get = function (url, headers) {
        return makeAjaxRequest('GET', headers, url);
    };

    Requester.prototype.post = function (url, headers, data) {
        return makeAjaxRequest('POST', headers, url, data);
    };

    Requester.prototype.put = function (url, headers, data) {
        return makeAjaxRequest('PUT', headers, url, data);
    };

    Requester.prototype.del = function (url, headers) {
        return makeAjaxRequest('DELETE', headers, url);
    };

    function makeAjaxRequest(method, headers, url, data) {
        var deffer = Q.defer();

        $.ajax({
            method: method,
            headers: headers,
            url: url,
            data: JSON.stringify(data),
            success: function (data) {
                deffer.resolve(data);
            },
            error: function (error) {
                deffer.reject(error);
            }
        });

        return deffer.promise;
    }

    return {
        load: function () {
            return new Requester();
        }
    }
}());