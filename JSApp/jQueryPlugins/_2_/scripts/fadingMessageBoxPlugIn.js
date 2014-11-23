(function($) {
    $.fn.messageBox = function() {
        var div = $('<div>').attr('id', 'message').text('some text');
        $(this).append(div);
        return this;
    }

    $.fn.success = function(successMessage) {
        var a = successMessage;
        var ch = $('#message');
        ch.text(a);
        ch.fadeIn(1000);
        ch.fadeOut(3000);


        return this;
    }


    $.fn.error = function(errorMessage) {
        var chi = $('#message');
        chi.text(errorMessage);
        chi.fadeIn(1000);
        chi.fadeOut(3000);
        return this;
    }

}(jQuery))
