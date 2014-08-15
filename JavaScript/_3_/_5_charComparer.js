function compareChars(a, b) {
    if (a.length === b.length) {
        var counter = 0;
        for (var i = 0; i < a.length; i++) {
            if (a[i] === b[i]) {
                counter++;
            }
        }
        if (counter === a.length) {
            return "Equal";
        } else {
            return "Not equal";
        }
    } else {
        return "Not equal";
    }
}
console.log(compareChars(['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q'], ['1', 'f', '1', 's', 'g', 'j', 'f', 'u', 's', 'q']));
console.log(compareChars(['3', '5', 'g', 'd'], ['5', '3', 'g', 'd']));
console.log(compareChars(['q', 'g', 'q', 'h', 'a', 'k', 'u', '8', '}', 'q', '.', 'h', '|', ';'], ['6', 'f', 'w', 'q', ':', '”', 'd', '}', ']', 's', 'r']));