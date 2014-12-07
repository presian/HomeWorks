var app = app || {};

app.controller = (function() {

    function BaseController(data) {
        this._data = data;
    }

    BaseController.prototype.loadHome = function(selector) {
        $(selector).load('./tamplates/home.html');
    };

    BaseController.prototype.loadLoginForm = function(selector) {
        $(selector).load('./tamplates/logform.html');
    };

    BaseController.prototype.loadRegistrationForm = function(selector) {
        $(selector).load('./tamplates/registrationForm.html');
    };

    BaseController.prototype.loadLibrary = function(selector) {
        this._data.lib.getLibrary(localStorage.getItem('sessionToken'))
            .then(function(data) {
                $.get('./tamplates/userLib.html', function(tamplate) {
                    var output = Mustache.render(tamplate, data);
                    $(selector).html(output);
                    $(selector).prepend($('<div>').attr('id', 'logout-row')
                        .text('Welcome ' + localStorage.userName + '!')
                        .append($('<input>').attr('type', 'button').attr('id', 'logoutButton').attr('value', 'Logout')))
                })
                return data;
            }, function(erorr) {
                return alert('Error can not render books!')
            });
    };

    BaseController.prototype.attachEventHandlers = function() {
        var selector = '#wrapper';
        makeLogin.call(this, selector);
        makeRegistration.call(this, selector);
        makeNewBook.call(this, selector);
        makeBookDelete.call(this, selector);
        makeShowBookEdit.call(this, selector);
        makeEditBook.call(this, selector);
        makeLogout.call(this, selector);
    };

    var makeLogin = function(selector) {
        var _this = this;
        $(selector).on('click', '#login-button', function() {
            var username = $('#login-username').val();
            var password = $('#login-password').val();
            if (!username || !password) {
                return alert('The name and password must be non-empty string');
                _this.loadLoginForm(selector);
            } else {
                _this._data.users.login(username, password)
                    .then(function(data) {
                        _this.loadLibrary(selector);
                        window.parent.location = "#/library";
                        return data;
                    }, function(error) {
                        _this.loadLoginForm(selector);
                        return alert('Invalid login data!')
                    })
            };
        })
    }

    var makeLogout = function(selector) {
        var _this = this;
        $(selector).on('click', '#logoutButton', function() {
            $('#logout-row').remove();
            _this.loadHome(selector);
            window.location.replace("#/");
            localStorage.clear();
        })
    }

    var makeRegistration = function(selector) {
        var _this = this;
        $(selector).on('click', '#registration-button', function() {
            var username = $('#registration-username').val();
            var password = $('#registration-password').val();
            if (!username || !password) {
                return alert('The name and password must be non-empty string');
            } else {
                _this._data.users.register(username, password)
                    .then(function(data) {
                        _this.loadLibrary(selector);
                        window.parent.location = "#/library";
                        return data;
                    }, function(error) {
                        return alert('Error loading library after registration');
                    })
            };
        })
    }

    var makeNewBook = function(selector) {
        var _this = this;
        $(selector).on('click', '#addNewBook', function() {
            var title = $('#addTitle').val();
            var author = $('#addAuthor').val();
            var isbn = $('#addIsbn').val();
            var userId = localStorage.getItem('userObjectId');
            var book = {
                title: title,
                author: author,
                isbn: isbn || null,
                ACL: {}
            }

            book.ACL[userId] = {
                "write": true,
                "read": true
            }

            if (!title || !author) {
                return alert('The author and title must be non-empty string!');
            } else {
                _this._data.lib.addBook(book)
                    .then(function(data) {
                        _this._data.lib.getBook(data.objectId, localStorage.getItem('sessionToken'))
                            .then(function(data) {
                                var row = $('<div>').attr('class', 'list-row').data('id', data.objectId);
                                row.append($('<div>').attr('class', 'list-row-section')
                                        .append($('<div>').attr('class', 'list-cell').text(data.title))
                                        .append($('<div>').attr('class', 'list-cell').text(data.author))
                                        .append($('<div>').attr('class', 'list-cell').attr('style', 'text-align: center').text(data.isbn)))
                                    .append($('<div>').attr('class', 'list-cell').attr('style', 'text-align: center')
                                        .append($('<input>').attr('type', 'button').attr('class', 'delete-button').attr('value', 'Delete')));
                                $('#library-list').append(row);
                                $('#edit-row').empty();
                                return data;
                            }, function(error) {
                                return alert('Unsuccessful adding a new book in list!')
                            })
                        return data;
                    }, function(error) {
                        return alert('Unsuccessful loading new book!')
                    })
            }
        })
    }

    var makeBookDelete = function(selector) {
        var _this = this;
        $(selector).on('click', '.delete-button', function(event) {
            var target = $(event.target).parents('.list-row');
            _this._data.lib.deleteBook(target.data('id'))
                .then(function(data) {
                    target.remove();
                    $('#edit-row').empty();
                }, function(error) {
                    return alert('Removing book from list fail!')
                })
        })
    }

    var makeShowBookEdit = function(selector) {
        var _this = this;
        $(selector).on('click', '.list-row-section', function(event) {
            var bookId = $(event.target).parents('.list-row').data('id');
            $('#edit-row').data('id', bookId).load('./tamplates/editBook.html')
        })
    }

    var makeEditBook = function(selector) {
        var _this = this;
        $(selector).on('click', '#edit-book-button', function(event) {
            var objectId = $('#edit-row').data('id');
            var title = $('#edit-title').val();
            var author = $('#edit-author').val();
            var isbn = $('#edit-isbn').val();

            if (!title || !author) {
                return alert('The title and author fields must have value!')
            }
            var data = {
                title: title,
                author: author,
                isbn: isbn
            }
            _this._data.lib.editBook(objectId, data)
                .then(function(data) {
                    $('#edit-row').empty();
                    _this.loadLibrary(selector);
                }, function(error) {
                    return alert('Can not load Library!');
                })
        })
    }

    return {
        get: function(data) {
            return new BaseController(data);
        }
    }
})();
