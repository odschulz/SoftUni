app.factory('userData', ['$resource', 'authentication', 'BASE_SERVICE_URL',function ($resource, authentication,BASE_SERVICE_URL) {
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

    function logoutUser() {
        var authenticationHeaders = authentication.getHeaders();

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

    function changePassword(data) {
        var authenticationHeaders = authentication.getHeaders();

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
        changePassword: changePassword
    }
}]);
