var module = (function() {
    var container = new Container();

    function newSectionButtonActionPicker() {
        var checkExistingOfContainer = document.getElementById('container');
        var titleOfSection = document.getElementById('newSectionTitle').value;

        if (titleOfSection != '') {
            if (checkExistingOfContainer === null) {
                container.addToDOM();
                addSection(titleOfSection);
            } else {
                addSection(titleOfSection);
            }
        } else {
            return alert('Every list must have name!')
        }
    }

    function addSection(title) {
        var section = new Section(title);
        section.addToDOM();
    }

    function addItem(text, section) {
        if (text === '') {
            return alert('Every list item must have content!')
        } else {
            var item = new Item(text);
            item.addToDOM(section);
        }
    }

    return {
        newSectionButtonActionPicker: newSectionButtonActionPicker,
        addItem: addItem
    }
}());

document.getElementById('newSectionButton').addEventListener('click', module.newSectionButtonActionPicker);