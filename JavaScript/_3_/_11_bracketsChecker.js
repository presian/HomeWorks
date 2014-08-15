function checkBrackets(a) {
    var length = a.length;
    var open = '(';
    var closed = ')';
    var openCount = 0;
    var closedCount = 0;
    for (var i = 0; i < length; i++) {
        if (a[i] === open) {
            openCount++;
        }
        if (a[i] === closed) {
            closedCount++;
        }
    }
    if (openCount === closedCount) {
        return "correct";
    } else {
        return "incorrect";
    }
}
console.log(checkBrackets('( ( a + b ) / 5 – d )'));
console.log(checkBrackets(') ( a + b ) )'));
console.log(checkBrackets('( b * ( c + d *2 / ( 2 + ( 12 – c / ( a + 3 ) ) ) )'));