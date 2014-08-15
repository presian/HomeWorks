function findMaxSequence(a) {
    var element;
    var counter = 1;
    var max = 0;
    for (var i = 0; i < a.length; i++) {
        if ((i < a.length - 1) && (a[i] === a[i + 1])) {
            counter++;
        } else if ((i === a.length - 1) && (a[i] === a[i - 1])) {
            counter++;
        } else {
            if (max <= counter) {
                element = i;
                max = counter;
            }
            counter = 1;
        }
    }
    var b = [];
    for (var j = 0; j < max; j++) {
        b[j] = a[element];
    }
    return b;
}
console.log(findMaxSequence([2, 1, 1, 2, 3, 3, 2, 2, 2, 1]));
console.log(findMaxSequence(['happy']));
console.log(findMaxSequence([2, 'qwe', 'qwe', 3, 3, '3']));