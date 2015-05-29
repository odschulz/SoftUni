app.factory('friendData', ['$resource', 'BASE_SERVICE_URL',function ($resource, BASE_SERVICE_URL) {

    function getMyFriendsPreviewData(authenticationHeaders) {

        return $resource(
            BASE_SERVICE_URL + 'me/friends/preview',
            null,
            {
                'get': {
                    method: 'GET',
                    headers: authenticationHeaders
                }
            })
            .get();
    }

    return {
        getMyFriendsPreviewData: getMyFriendsPreviewData
    }
}]);

