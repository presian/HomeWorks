var app = app || {};
(function() {
    var baseUrl = 'https://api.parse.com/1/';
    var requester = app.requester.get();
    var data = app.data.get(baseUrl, requester);
    var controller = app.controller.get(data);
    controller.attachEventHandlers();

    app.router = Sammy(function(selector) {
        var selector = '#wrapper';

        this.get('#/', function() {
            controller.loadHome(selector);
        })

        this.get('#/login', function() {
            controller.loadLoginForm(selector);
        })

        this.get('#/registration', function() {
            controller.loadRegistrationForm(selector);
        })

        this.get('#/library', function() {
            controller.loadLibrary(selector);
        })
    })
    app.router.run('#/');
}())
