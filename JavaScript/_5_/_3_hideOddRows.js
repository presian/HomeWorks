function changeButton() {
    button = document.getElementById('btnHideOddRows');
    var text = button.innerHTML;
    if (text === 'Hide Odd Rows') {
        text = 'Show Odd Rows';
    } else {
        text = 'Hide Odd Rows';
    };
    button.innerHTML = text;

}

function hideOddRows() {
    var text = button.innerHTML;
    var rows = document.querySelectorAll('body table tr');
    var i;
    var length = rows.length;
    if (text === 'Hide Odd Rows') {
        for (i = 0; i < length; i += 2) {
            rows[i].style.display = 'none';
        }
    } else {
        for (i = 0; i < length; i++) {
            rows[i].style.display = 'table';
        }
    };
}

function twoLikeOne() {
    hideOddRows();
    changeButton();

}
var button = document.getElementById('btnHideOddRows');
button.addEventListener('click', twoLikeOne, false);