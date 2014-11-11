var Container = (function() {

    function Container() {};

    Container.prototype = {
        addToDOM: function() {
            var wrapper = document.getElementById('wrapper');
            var createNewListSection = document.getElementById('createNewListSection');

            var container = document.createElement('div');
            container.setAttribute('id', 'container');
            wrapper.insertBefore(container, createNewListSection);
        }
    }

    return Container;
})();