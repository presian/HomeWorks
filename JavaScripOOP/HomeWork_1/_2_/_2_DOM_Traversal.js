'use strict';
function traverse(selector) {
    var element = document.querySelector(selector);
    traverseChildElements(element, '');

    function traverseChildElements(element, spacing) {
        var child, elementID, elementClass;
        spacing = spacing || "  ";

        elementID = element.getAttribute('id');
        elementClass = element.getAttribute('class');

        console.log(spacing + element.nodeName.toLowerCase() + ': '
                            + (elementID!=null ? 'id="' + elementID + '"' : '')
                            + (elementClass != null ? 'class="' + elementClass + '"' : ''));

        for (var index = 0; index < element.children.length; index++) {
            child = element.children[index];
            if (child.nodeType === document.ELEMENT_NODE) {
                traverseChildElements(child, spacing + '    ');
            }
        }
    }
    }
}

var selector = ".birds";
traverse(selector);