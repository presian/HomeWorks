function bitChecker(n) {
    var p = 3;
    var mask = 1 << p;
    var result = n & mask;
    result = result >> p;
    if (result === 1) {
        return true;
    } else {
        return false;
    }
}
console.log(bitChecker(333));
console.log(bitChecker(425));
console.log(bitChecker(2567564754));