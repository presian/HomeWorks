var app = app || {};

app.data = (function() {
    function Data(baseUrl, requester) {
        this.users = new Users(baseUrl, requester);
        this.lib = new Library(baseUrl, requester);
    }

    var userDataStorage = (function() {
        var headers = {
            'X-Parse-Application-Id': 'M6gn8Dm1y6dnh6cFDQBEzKg7SfC7jMhuOuth2lB1',
            'X-Parse-REST-API-Key': 'bmmbPOUgTFycICCsYYwVVVNKyhqHW3HtNXCMjJQt',
            'X-Parse-Session-Token': getSessionToken()
        }

        function setSessionToken(sessionToken) {
            localStorage.setItem('sessionToken', sessionToken);
        }

        function getSessionToken(sessionToken) {
            localStorage.getItem('sessionToken');
        }

        function setUserName(userName) {
            localStorage.setItem('userName', userName);
        }

        function getUserName() {
            localStorage.getItem('userName')
        }

        function setUserObjectId(objectId) {
            localStorage.setItem('userObjectId', objectId);
        }

        function getUserObjectId() {
            localStorage.getItem('userObjecId');
        }

        function getHeaders() {
            return headers;
        }

        return {
            getHeaders: getHeaders,
            getUserName: getUserName,
            getSessionToken: getSessionToken,
            setUserName: setUserName,
            setSessionToken: setSessionToken,
            setUserObjectId: setUserObjectId,
            getUserObjectId: getUserObjectId
        }
    }())

    var Users = (function() {
        function Users(baseUrl, requester) {
            this._url = baseUrl;
            this._requester = requester;
            this._headers = userDataStorage.getHeaders();
        }

        Users.prototype.login = function(username, password) {
            var url = this._url + 'login?username=' + username + '&password=' + password;
            return this._requester.get(url, this._headers)
                .then(function(data) {
                    userDataStorage.setSessionToken(data.sessionToken);
                    userDataStorage.setUserName(data.username);
                    userDataStorage.setUserObjectId(data.objectId);
                    return data;
                }, function(error) {
                    app.controller.loadLoginForm('#wrapper');
                    return alert('Unsuccessful login!')

                })
        };

        Users.prototype.register = function(username, password) {
            var user = {
                username: username,
                password: password
            }
            var url = this._url + 'users';
            return this._requester.post(url, user, this._headers)
                .then(function(data) {
                    userDataStorage.setSessionToken(data.sessionToken)
                    userDataStorage.setUserName(username);
                    userDataStorage.setUserObjectId(data.objectId);
                    return data;
                }, function(error) {
                    alert('Error - Unsuccessful registration!');
                })
        };

        return Users;
    })();

    var Library = (function(baseUrl, requester) {
        function Library(baseUrl, requester) {
            this._url = baseUrl + 'classes/Book';
            this._requester = requester;
            this._headers = userDataStorage.getHeaders();
        }

        Library.prototype.getLibrary = function(sessionToken) {
            return this._requester.get(this._url, this._headers);
        }

        Library.prototype.addBook = function(book) {
            return this._requester.post(this._url, book, this._headers);
        }

        Library.prototype.getBook = function(bookId) {
            return this._requester.get(this._url + '/' + bookId, this._headers);
        }

        Library.prototype.deleteBook = function(bookId) {
            return this._requester.del(this._url + '/' + bookId, this._headers);
        };

        Library.prototype.editBook = function(bookId, data) {
            return this._requester.put(this._url + '/' + bookId, data, this._headers);
        };
        return Library;
    }())

    return {
        get: function(baseUrl, requester) {
            return new Data(baseUrl, requester);
        }
    }
}())
