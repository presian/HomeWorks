function sortNums(b, c) {
    return b - c;
}

function findMinAndMax(a) {
    a.sort(sortNums);
    return "Min -> " + a[0] + "\nMax -> " + a[a.length - 1];
}
console.log(findMinAndMax([1, 2, 1, 15, 20, 5, 7, 31]));
console.log(findMinAndMax([2, 2, 2, 2, 2]));
console.log(findMinAndMax([500, 1, -23, 0, -300, 28, 35, 12]));