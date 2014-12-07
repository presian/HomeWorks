var app = app || {};

app.requester = (function() {
    function AjaxRequester() {
        this.get = makeGetRequest;
        this.put = makePutRequest;
        this.post = makePostRequest;
        this.del = makeDeleteRequest;
    }

    var makeRequest = function(url, method, data, headers) {
        var def = Q.defer();

        $.ajax({
            headers: headers,
            url: url,
            method: method,
            contentType: 'application/json',
            data: JSON.stringify(data),
            success: function(data) {
                def.resolve(data);
            },
            error: function(error) {
                def.reject(error)
            }
        });

        return def.promise;
    }

    var makeHeaders = function(headers) {
        var personalHeader = JSON.parse(JSON.stringify(headers));
        personalHeader['X-Parse-Session-Token'] = localStorage.getItem('sessionToken');
        return personalHeader;
    }

    var makeGetRequest = function(url, headers) {
        return makeRequest(url, 'GET', null, makeHeaders(headers));
    }

    var makePostRequest = function(url, data, headers) {
        return makeRequest(url, 'POST', data, makeHeaders(headers));
    }

    var makePutRequest = function(url, data, headers) {
        return makeRequest(url, 'PUT', data, makeHeaders(headers));
    }

    var makeDeleteRequest = function(url, headers) {
        return makeRequest(url, 'DELETE', null, makeHeaders(headers));
    }

    return {
        get: function() {
            return new AjaxRequester();
        }
    }
})();
