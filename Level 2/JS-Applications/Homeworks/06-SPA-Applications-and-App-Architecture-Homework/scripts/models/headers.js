define([],
    function () {
        function Headers(appId, restAPIKey) {
            this.appId = appId;
            this.restAPIKey = restAPIKey;
        }

        Headers.prototype.getHeaders = function getHeaders() {
            return {
                'X-Parse-Application-Id': this.appId,
                'X-Parse-REST-API-Key': this.restAPIKey,
                'Content-Type': 'application/json'
            };
        };

        return {
            load: function (applicationId, restAPIKey) {
                return new Headers(applicationId, restAPIKey);
            }
        };
    });