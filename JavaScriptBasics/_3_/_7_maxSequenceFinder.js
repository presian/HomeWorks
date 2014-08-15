function findMaxSequence(a) {
    var counter = 1;
    var max = 0;
    var index = 0;
    for (var i = 0; i < a.length; i++) {
        if ((i < a.length - 1) && (a[i] < a[i + 1])) {
            counter++;
        } else if ((i === a.length - 1) && (a[i] > a[i - 1])) {
            counter++;
            if (max < counter) {
                max = counter - 1;
                index = i;
            }
        } else {
            if (max < counter) {
                max = counter;
                index = i;
            }
            counter = 1;
        }
    }
    if (max === 1) {
        return "no";
    } else {
        var b = [];
        for (var j = 0; j < max; j++) {
            b[j] = a[(index - max) + 1 + j];
        }
        return b;
    }
}
console.log(findMaxSequence([3, 2, 3, 4, 2, 2, 4]));
console.log(findMaxSequence([3, 5, 4, 6, 1, 2, 3, 6, 10, 32]));
console.log(findMaxSequence([3, 2, 1]));