function findPalindromes(a) {
    var arr = [];
    var outArr = [];
    var reverse = '';
    arr = a.toLowerCase().split(/\W+/g);
    for (var j = 7; j < arr.length; j++) {
        if (arr[j] === '') {
            arr.splice(j, 1);
        }
    }
    for (var i = 0; i < arr.length; i++) {
        reverse = arr[i].split('').reverse().join('');
        if (arr[i] === reverse) {
            outArr.push(arr[i]);
        }
    }
    return outArr.join(', ');
}
console.log(findPalindromes('There is a man, his name was Bob.'));