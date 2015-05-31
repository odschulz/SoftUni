app.factory('userData', ['$resource', 'BASE_SERVICE_URL',function ($resource, BASE_SERVICE_URL) {
    //function sampleGetRequest() {
    //    var resource = $resource(BASE_SERVICE_URL + 'ads:adId', {adId: '@id'}, {
    //        update: {method: 'PUT'}
    //    });
    //
    //    function editAd(adId, ad) {
    //        return resource.update({id: adId}, ad);
    //    }
    //
    //    function getPublicAds() {
    //        return resource.get();
    //    }
    //
    //    function getAdById(adId) {
    //        return resource.get({id: adId});
    //    }
    //
    //    function addAd(ad) {
    //        return resource.save(ad);
    //    }
    //
    //    function deleteAd(adId) {
    //        return resource.delete({id: adId});
    //    }
    //}

    function registerUser(user) {
        return $resource(BASE_SERVICE_URL + 'users/register')
            .save(user)
    }

    function loginUser(user) {
        return $resource(BASE_SERVICE_URL + 'users/login')
            .save(user);
    }

    function logoutUser(authenticationHeaders) {

        return $resource(
            BASE_SERVICE_URL + 'users/logout',
            null,
            {
                'post': {
                    method: 'POST',
                    headers: authenticationHeaders
                }
            })
            .post();
    }

    function getDataAboutMe(authenticationHeaders) {

        return $resource(
            BASE_SERVICE_URL + 'me',
            null,
            {
                'get': {
                    method: 'GET',
                    headers: authenticationHeaders
                }
            })
            .get();
    }

    function getUserPreviewData(authenticationHeaders, username) {

        return $resource(
            BASE_SERVICE_URL + 'users/' + username + '/preview',
            null,
            {
                'get': {
                    method: 'GET',
                    headers: authenticationHeaders
                }
            })
            .get();
    }

    function getUserFullData(authenticationHeaders, username) {

        return $resource(
            BASE_SERVICE_URL + 'users/' + username,
            null,
            {
                'get': {
                    method: 'GET',
                    headers: authenticationHeaders
                }
            })
            .get();
    }

    function searchForUsers(authenticationHeaders, searchPhrase) {
        return $resource(
            BASE_SERVICE_URL + 'users/search?searchTerm=' + searchPhrase,
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


    function editProfile(data, authenticationHeaders) {
        return $resource(
            BASE_SERVICE_URL + 'me',
            null,
            {
                'put': {
                    method: 'PUT',
                    headers: authenticationHeaders
                }
            })
            .put(data);
    }
    
    function changePassword(data, authenticationHeaders) {

        return $resource(
            BASE_SERVICE_URL + 'me/changepassword',
            null,
            {
                'put': {
                    method: 'PUT',
                    headers: authenticationHeaders
                }
            })
            .put(data);
    }

    return {
        register: registerUser,
        login: loginUser,
        logout: logoutUser,
        getDataAboutMe: getDataAboutMe,
        changePassword: changePassword,
        editProfile: editProfile,
        getUserPreviewData: getUserPreviewData,
        getUserFullData: getUserFullData,
        searchForUsers: searchForUsers
    }
}]);
