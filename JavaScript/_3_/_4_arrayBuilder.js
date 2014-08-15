function createArray() {
    var a = new Array(20);
    for (var i = 0; i < a.length; i++) {
        a[i] = i * 5;
    }
    return a;
}
console.log(createArray());