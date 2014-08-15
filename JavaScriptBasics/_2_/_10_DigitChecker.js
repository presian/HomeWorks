function checkDigit(n) {
    var num = n.toString();
    var a = [];
    for (var i = 0; i < num.length; i++) {
        a.push(+num.charAt(i));
    }
    if (a[a.length - 3] === 3) {
        return true;
    } else {
        return false;
    }
}
console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));