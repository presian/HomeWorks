// Create a jQuery plugin for creating a TreeView:
// •	A TreeView contains several items 
// •	Each item may contain items of its own
// •	Clicking on an item shows/hides its direct children

$(document).ready(function() {
    $('ul').find('ul').hide();
    $('ul').treeView();
})
