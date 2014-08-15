function findCardFrequency(a) {
    var arr = [];
    arr = a.split(/\s+/g);
    secondArr = [];
    for (var i = 0; i < arr.length; i++) {
        if (arr[i].length === 3) {
            secondArr[i] = arr[i].slice(0, 2);
        } else {
            secondArr[i] = arr[i].slice(0, 1);
        };
    };
    // console.log(secondArr);
    var map = {};
    var counter = 0;
    for (var j = 0; j < secondArr.length; j++) {
        for (var k = 0; k < secondArr.length; k++) {
            if (secondArr[j] === secondArr[k]) {
                counter++;
            }
        }
        map[secondArr[j]] = (counter / secondArr.length * 100).toFixed(2) + '%';
        counter = 0;
    }
    var out = [];
    for (var s = 0; s < secondArr.length; s++) {
        out[s] = secondArr[s];
    }
    counter = 0;
    for (var z = 0; z < out.length; z++) {
        for (var y = z + 1; y < secondArr.length; y++) {
            if (out[z] === secondArr[y]) {
                out[y] = '';
            };
        }
        counter = 0;
    }
    // console.log(secondArr);
    //console.log(out);
    for (var r = 0; r < out.length; r++) {
        for (key in map) {
            if (out[r] === key) {
                console.log(key + ' -> ' + map[key]);
            };
        };
    }
    // for (key in map) {
    //     console.log(key + ' -> ' + map[key]);
    // };

}
findCardFrequency('8♥ 2♣ 4♦ 10♦ J♥ A♠ K♦ 10♥ K♠ K♦');
findCardFrequency('J♥ 2♣ 2♦ 2♥ 2♦ 2♠ 2♦ J♥ 2♠');
findCardFrequency('10♣ 10♥');