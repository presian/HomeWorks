function isPrime(n) {
    var count = 0;
    if (n < 2) {
        return false;
    } else {
        for (var i = 1; i <= n; i++) {
            if (n % i === 0) {
                count++;
            }
        }
        if (count == 2) {
            return true;
        } else {
            return false;
        }
    }
}
console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));