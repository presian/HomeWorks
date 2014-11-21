// Problem 1.	Element Insertion
// Using jQuery write a script for adding elements before/after other elements.
//=============================================================================

var beforeElement = $('<div>').attr('class', 'upper');
var underElement = $('<div>').attr('class', 'under');
var pivot = $('#pivot');
beforeElement.prependTo('body');
underElement.insertAfter('#pivot');
