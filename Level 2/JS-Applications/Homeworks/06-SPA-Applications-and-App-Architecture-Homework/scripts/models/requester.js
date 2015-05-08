define(['Q', 'jquery'], function (Q, $) {
    function Requester() {
    }

    Requester.prototype.get = function get(url, headers) {
        return makeAjaxRequest('GET', url, headers, null);
    };

    Requester.prototype.post = function post(url, headers, itemData) {
        return makeAjaxRequest('POST', url, headers, itemData);
    };

    Requester.prototype.put = function put(url, headers, itemData) {
        return makeAjaxRequest('PUT', url, headers, itemData);
    };

    Requester.prototype.del = function del(url, headers) {
        return makeAjaxRequest('DELETE', url, headers, null);
    };

    function makeAjaxRequest(method, url, headers, itemData) {
        var deferred = Q.defer();

        $.ajax({
            method: method,
            headers: headers,
            url: url,
            data: JSON.stringify(itemData),
            success: function (data) {
                deferred.resolve(data);
            },
            error: function (error) {
                deferred.reject(error);
            }
        });

        return deferred.promise;
    }

    return  {
        load: function () {
            return new Requester();
        }
    };
});