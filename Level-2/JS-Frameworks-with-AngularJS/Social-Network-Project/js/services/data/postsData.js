
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

    function likePost(authenticationHeaders, postId) {
        return $resource(
            BASE_SERVICE_URL + '/Posts/' + postId + '/likes',
            null,
            {
                'post': {
                    method: 'POST',
                    headers: authenticationHeaders
                }
            })
            .post();
    }

    function unLikePost(authenticationHeaders, postId) {
        return $resource(
            BASE_SERVICE_URL + '/Posts/' + postId + '/likes',
            null,
            {
                'del': {
                    method: 'DELETE',
                    headers: authenticationHeaders
                }
            })
            .del();
    }

    function likeComment(authenticationHeaders, postId, commentId) {
        return $resource(
            BASE_SERVICE_URL + '/Posts/' + postId + '/comments/' + commentId + '/likes',
            null,
            {
                'post': {
                    method: 'POST',
                    headers: authenticationHeaders
                }
            })
            .post();
    }

    function unlikeComment(authenticationHeaders, postId, commentId) {
        return $resource(
            BASE_SERVICE_URL + '/Posts/' + postId + '/comments/' + commentId + '/likes',
            null,
            {
                'del': {
                    method: 'DELETE',
                    headers: authenticationHeaders
                }
            })
            .del();
    }


    return {
        getNewsFeed: getNewsFeed,
        addCommentToPost : addCommentToPost,
        getPostComments: getPostComments,
        likePost: likePost,
        unLikePost: unLikePost,
        likeComment: likeComment,
        unlikeComment: unlikeComment
    }
}]);

