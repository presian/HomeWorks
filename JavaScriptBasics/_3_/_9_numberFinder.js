function findMostFreqNum(a) {
    var counter = 0;
    var max = 0;
    var index = 0;
    for (var i = 0; i < a.length; i++) {
        for (var j = 0; j < a.length; j++) {
            if (a[i] === a[j]) {
                counter++;
            }
        }
        if (counter > max) {
            max = counter;
            index = i;
        }
        counter = 0;
    }
    return a[index] + "(" + max + "times)";
}
console.log(findMostFreqNum([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]));
console.log(findMostFreqNum([2, 1, 1, 5, 7, 1, 2, 5, 7, 3, 87, 2, 12, 634, 123, 51, 1]));
console.log(findMostFreqNum([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13]));