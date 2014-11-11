var domModule = function () {

    var addChild = function (newChildTag, parentSelector) {
        var parent = document.querySelector(parentSelector);
        var child = document.createElement(newChildTag);
        parent.appendChild(child);
    };

    var removeChild = function(parentSelector, childToRemove) {
        var parent = document.querySelector(parentSelector);
        var child = document.querySelector(childToRemove);
        parent.removeChild(child);
    };

    var addHandler = function(selector, eventType, action) {
        var elements = document.querySelectorAll(selector);
        for (var index = 0; index < elements.length; index++) {
            elements[index].addEventListener(eventType, action);
        }
    };

    var retrieveAll = function(selector) {
        var elements = document.querySelectorAll(selector);
        return elements;
    };

    return {
        addChild: addChild,
        removeChild: removeChild,
        addHandler: addHandler,
        retrieveAll: retrieveAll
};
}();

domModule.addChild('li', ".birds-list");
domModule.removeChild("ul.birds-list", "li:first-child");
domModule.addHandler("li.bird", 'click', function () { alert("I'm a bird!"); });
console.log(domModule.retrieveAll(".bird"));// To see this please open the console in browser
