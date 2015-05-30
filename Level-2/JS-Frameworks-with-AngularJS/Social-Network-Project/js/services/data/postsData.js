
app.factory('postsData', ['$resource', 'BASE_SERVICE_URL', 'PAGE_SIZE',function ($resource, BASE_SERVICE_URL, PAGE_SIZE) {

    function getNewsFeed(authenticationHeaders) {

        return $resource(
            BASE_SERVICE_URL + '/me/feed?StartPostId=&PageSize=' + PAGE_SIZE,
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

    function addCommentToPost(authenticationHeaders, postId, comment) {

        return $resource(
            BASE_SERVICE_URL + '/posts/' + postId + '/comments',
            null,
            {
                'post': {
                    method: 'POST',
                    headers: authenticationHeaders
                }
            })
            .post(comment);
    }

    function getPostComments(authenticationHeaders, postId) {

        return $resource(
            BASE_SERVICE_URL + '/posts/' + postId + '/comments',
            null,
            {
                'get': {
                    method: 'GET',
                    headers: authenticationHeaders,
                    isArray: true
                }
            })
            .get();
    }


    return {
        getNewsFeed: getNewsFeed,
        addCommentToPost : addCommentToPost,
        getPostComments: getPostComments
    }
}]);

