(function() {
    require(["classes/Module"], function(Module) {
        var Module = new Module();
        document.getElementById('newSectionButton').addEventListener('click', Module.newSectionButtonActionPicker);
    });
})();