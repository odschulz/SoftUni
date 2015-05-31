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

    function getGetFriendsOfFriendPreviewData(authenticationHeaders, username) {

        return $resource(
            BASE_SERVICE_URL + 'users/' + username + '/friends/preview',
            null,
            {
                'get': {
                    method: 'GET',
                    headers: authenticationHeaders
                }
            })
            .get();
    }

    function getFriendsOfFriendDetailedList(authenticationHeaders, username) {

        return $resource(
            BASE_SERVICE_URL + 'users/' + username + '/friends',
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

    function getFriendRequests(authenticationHeaders) {
        return $resource(
            BASE_SERVICE_URL + 'me/requests',
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

    function approveFriendRequest(authenticationHeaders, requestId) {
        //me/requests/2?status=approved
        return $resource(
            BASE_SERVICE_URL + 'me/requests/' + requestId + '?status=approved',
            null,
            {
                'put': {
                    method: 'PUT',
                    headers: authenticationHeaders
                }
            })
            .put();
    }

    function rejectFriendRequest(authenticationHeaders, requestId) {
        //me/requests/2?status=approved
        return $resource(
            BASE_SERVICE_URL + 'me/requests/' + requestId + '?status=rejected',
            null,
            {
                'put': {
                    method: 'PUT',
                    headers: authenticationHeaders
                }
            })
            .put();
    }

    return {
        getMyFriendsPreviewData: getMyFriendsPreviewData,
        getMyFriendsList: getMyFriendsList,
        getGetFriendsOfFriendPreviewData: getGetFriendsOfFriendPreviewData,
        getFriendsOfFriendDetailedList: getFriendsOfFriendDetailedList,
        sendFriendRequest: sendFriendRequest,
        getFriendRequests: getFriendRequests,
        approveFriendRequest: approveFriendRequest,
        rejectFriendRequest: rejectFriendRequest
    }
}]);

