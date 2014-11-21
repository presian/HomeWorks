// Problem 2.	Background Color Switch
// Write a script using jQuery for switching the background color of elements with a specified class. 
// The input should be read from an input form.
// ===============================================================================

var ChangeColor = (function() {

    function changeColor() {
        var pickedClass = '.' + $('#classPicker').val();
        console.log(pickedClass);
        var pickedColor = $('#colorPicker').val();
        console.log(pickedColor);
        $(pickedClass).css('background-color', pickedColor);
    }
    return {
        ChangeColor: changeColor
    }
}());
