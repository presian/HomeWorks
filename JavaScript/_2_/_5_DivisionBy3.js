function divisionBy3(n) {
    if (n < 10) {
        return false;
    } else {
        var a = n.toString();
        var sum = 0;
        for (var i = 0; i < a.length; i++) {
            sum += +a.charAt(i);
        }
        if (sum % 3 === 0) {
            return "the number is divided by 3 without remainder";
        } else {
            return "the number is not divided by 3 without remainder";
        }
    }
}
console.log(divisionBy3(12));
console.log(divisionBy3(189));
console.log(divisionBy3(591));