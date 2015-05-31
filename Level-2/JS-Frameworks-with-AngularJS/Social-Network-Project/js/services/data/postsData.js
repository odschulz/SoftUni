
app.factory('postsData', ['$resource', 'BASE_SERVICE_URL', function ($resource, BASE_SERVICE_URL) {

    function getNewsFeed(authenticationHeaders, startPostId, pageSize) {

        return $resource(
            BASE_SERVICE_URL + '/me/feed?StartPostId=' + startPostId + '&PageSize=' + pageSize,
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

    function getUserWall(authenticationHeaders, username, startPostId, pageSize) {
        return $resource(
            BASE_SERVICE_URL + '/users/' + username + '/wall?StartPostId=' + startPostId + '&PageSize=' + pageSize,
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

    function addNewPost(authenticationHeaders, data) {
        return $resource(
            BASE_SERVICE_URL + '/posts',
            null,
            {
                'post': {
                    method: 'POST',
                    headers: authenticationHeaders
                }
            })
            .post(data);
    }

    function editPostById(authenticationHeaders, id, data) {
        return $resource(
            BASE_SERVICE_URL + '/Posts/' + id,
            null,
            {
                'put': {
                    method: 'PUT',
                    headers: authenticationHeaders
                }
            })
            .put(data);
    }

    function deletePostById(authenticationHeaders, id) {
        return $resource(
            BASE_SERVICE_URL + '/Posts/' + id,
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
        getUserWall: getUserWall,
        addCommentToPost : addCommentToPost,
        getPostComments: getPostComments,
        likePost: likePost,
        unLikePost: unLikePost,
        likeComment: likeComment,
        unlikeComment: unlikeComment,
        addNewPost: addNewPost,
        editPostById: editPostById,
        deletePostById: deletePostById
    }
}]);

