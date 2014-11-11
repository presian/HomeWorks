define(['classes/Item'], function(Item) {
    var Section = (function() {

        function Section(title) {
            this._title = title;
        }

        Section.prototype = {
            addItem: function(item) {
                if (item instanceof Item) {
                    this._items.push(item);
                } else {
                    return;
                };
            },

            addToDOM: function() {
                var newSection = document.createElement('div');
                newSection.setAttribute('class', 'section');

                var listSection = document.createElement('div');
                listSection.setAttribute('class', 'listSection');

                var title = document.createElement('h2');
                title.setAttribute('class', 'title');
                title.innerHTML = this._title;

                newSection.appendChild(title);

                var addSectionRow = document.createElement('div');
                addSectionRow.setAttribute('class', 'addSectionRow');

                var addSection = document.createElement('div');
                addSection.setAttribute('class', 'addSection');

                var inputAddSection = document.createElement('input');
                inputAddSection.setAttribute('type', 'text');
                inputAddSection.setAttribute('placeholder', 'Add item...');
                inputAddSection.setAttribute('class', 'inputAddSection');

                var buttonAddSection = document.createElement('button');
                buttonAddSection.setAttribute('class', 'buttonAddSection');
                buttonAddSection.innerHTML = '+';

                buttonAddSection.addEventListener('click', function() {
                    var text = inputAddSection.value;
                    if (text === '') {
                        return alert('Every list item must have content!')
                    } else {
                        var item = new Item(text);
                        item.addToDOM(listSection);
                    }
                });

                addSection.appendChild(inputAddSection);
                addSection.appendChild(buttonAddSection);

                addSectionRow.appendChild(addSection);

                newSection.appendChild(listSection);
                newSection.appendChild(addSectionRow);

                var container = document.getElementById('container');
                container.appendChild(newSection);
            }
        }
        return Section;
    }());
    return Section;
});