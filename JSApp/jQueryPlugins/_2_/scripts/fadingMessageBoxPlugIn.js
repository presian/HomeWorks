(function($) {
    $.fn.messageBox = function() {
        var div = $('<div>').attr('class', 'message');
        $(this).append(div);
        return this;
    }

    $.fn.success = function(successMessage) {
        $this = $(this);
        var ch = $this.children('.message');
        ch.text(successMessage);
        ch.fadeIn(1000);
        ch.fadeOut(3000);
        return this;
    }

    $.fn.error = function(errorMessage) {
        $this = $(this);
        var chi = $this.children('.message');
        chi.text(errorMessage);
        chi.fadeIn(1000);
        chi.fadeOut(3000);
        return this;
    }
}(jQuery))
