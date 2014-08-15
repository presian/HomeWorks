function displayProperties() {
    var out = [];
    for (var properties in document) {
        out.push(properties);
    };

    out.sort();

    for (var i = 0; i < out.length; i++) {
        console.log(out[i]);
    }

}
displayProperties();