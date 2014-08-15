function biggerThanNeighbors(index, arr) {
    var l = arr.length;
    if ((index >= l - 1) || (index < 0)) {
        return 'invalid index';
    } else if ((index === 0) || (index === l - 1)) {
        return 'only one neighbor';
    } else if ((arr[index - 1] >= arr[index]) || (arr[index + 1] >= arr[index])) {
        return 'not bigger';
    } else {
        return 'bigger';
    };
}
console.log(biggerThanNeighbors(2, [1, 2, 3, 3, 5]));
console.log(biggerThanNeighbors(2, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbors(5, [1, 2, 5, 3, 4]));
console.log(biggerThanNeighbors(0, [1, 2, 5, 3, 4]));