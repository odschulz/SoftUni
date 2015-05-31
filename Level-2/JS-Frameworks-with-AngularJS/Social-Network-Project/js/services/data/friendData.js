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

    function getMyFriendsList(authenticationHeaders) {

        return $resource(
            BASE_SERVICE_URL + 'me/friends',
            null,
            {
                'get': {
                    method: 'GET',
                    isArray: true,
                    headers: authenticationHeaders
                }
            })
            .get();
    }

    function sendFriendRequest(authenticationHeaders, username) {

        return $resource(
            BASE_SERVICE_URL + 'me/requests/' + username,
            null,
            {
                'post': {
                    method: 'POST',
                    headers: authenticationHeaders
                }
            })
            .post();
    }

    return {
        getMyFriendsPreviewData: getMyFriendsPreviewData,
        getMyFriendsList: getMyFriendsList,
        sendFriendRequest: sendFriendRequest
    }
}]);

