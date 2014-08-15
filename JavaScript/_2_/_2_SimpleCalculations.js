function roundNumber(value) {
    var n = Math.round(value);
    var f = Math.floor(value);
    return n + "\n" + f;
}

console.log(roundNumber(22.7));
console.log(roundNumber(12.3));
console.log(roundNumber(58.7));