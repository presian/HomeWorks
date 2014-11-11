var specialConsole = function () {

    function replacePlaceHolders(sentence) {
        var inputText = sentence[0];
        if (sentence.length > 1) {
            for (var index = 1; index < sentence.length; index++) {
                var replacePatern = '{' + (index - 1) + '}';
                var replaceItem = sentence[index];
                inputText = inputText.replace(replacePatern, replaceItem);
            }
        }
        return inputText.toString();

    }

    var writeLine = function () {
        console.log(replacePlaceHolders(arguments));
    };

    var writeError = function() {
        console.log(replacePlaceHolders(arguments));
    };

    var writeWarning = function() {
        console.log(replacePlaceHolders(arguments));
    };


    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning
    };
}();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0} ", "hello");
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");


