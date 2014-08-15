function treeHouseCompare(a, b) {
    var tree = a * a + ((a * ((a * 2) / 3)) / 2);
    var house = b * b / 3 + (Math.PI * ((2 * b / 3) * (2 * b / 3)));
    if (tree > house) {
        return "tree/" + tree.toFixed(2);
    } else {
        return "house/" + house.toFixed(2);
    }
}
console.log(treeHouseCompare(3, 2));
console.log(treeHouseCompare(3, 3));
console.log(treeHouseCompare(4, 5));