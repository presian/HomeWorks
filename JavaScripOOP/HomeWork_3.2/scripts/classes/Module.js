define(["classes/Container", "classes/Section", "classes/Item"], function(Container, Section, Item) {
    var Module = (function() {
        var container = new Container();

        function Module() {

        }

        Module.prototype = {
            newSectionButtonActionPicker: function() {
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

                function addSection(title) {
                    var section = new Section(title);
                    section.addToDOM();
                }
            }
        };

        return Module;
    }());

    return Module;
});