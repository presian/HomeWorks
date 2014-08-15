function sortArray(a) {
    var i, j, tmp, tmp2;
    for (i = 0; i < a.length - 1; i++) {
        tmp = i;
        for (j = i + 1; j < a.length; j++) {
            if (a[j] < a[tmp]) {
                tmp = j;
            }
        }
        tmp2 = a[tmp];
        a[tmp] = a[i];
        a[i] = tmp2;
    }
    return a;
}
console.log(sortArray([5, 4, 3, 2, 1]));
console.log(sortArray([12, 12, 50, 2, 6, 22, 51, 712, 6, 3, 3]));