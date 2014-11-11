define(function() {
    var Item = (function() {

        function Item(content, status) {
            this._content = content;
            this._status = 'open';

        }

        function changeStatus(box, text) {
            var isChecked = box.checked;

            if (isChecked) {
                text.style.backgroundColor = "#00FF00";
            } else {
                text.style.backgroundColor = "white";
            }
        }

        Item.prototype = {
            addToDOM: function(list) {
                var row = document.createElement('div');
                row.setAttribute('class', 'listItem');

                var checkBox = document.createElement('input');
                checkBox.setAttribute('type', 'checkbox');
                checkBox.setAttribute('class', 'check');

                var text = document.createElement('div');
                text.setAttribute('class', 'content');
                text.innerHTML = this._content;

                checkBox.addEventListener('change', function() {
                    changeStatus(checkBox, text);
                })

                row.appendChild(checkBox);
                row.appendChild(text);
                var numberOfChilds = list.childNodes;
                if (numberOfChilds.length > 0) {
                    text.style.borderTop = '1px solid gray';
                };
                list.appendChild(row);

                var parent = row.parentNode;
                parent.style.border = '1px solid gray';
            }
        };
        return Item;
    }());
    return Item;
});