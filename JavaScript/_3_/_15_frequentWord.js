function findMostFreqWord(a) {
    var arr = [];
    var counter = 0;
    var max = 0;
    var array = {};
    arr = a.toLowerCase().split(/\W+/g);
    arr.sort();
    for (var i = 0; i < arr.length; i++) {
        if (arr[i] === '') {
            arr.splice(i, 1);
        };
    };
    for (var j = 0; j < arr.length; j++) {
        for (var k = 0; k < arr.length; k++) {
            if (arr[j] === arr[k]) {
                counter++;
            };
        };
        array[arr[j]] = counter;
        if (counter > max) {
            max = counter;
        };
        counter = 0;
    };
    for (key in array) {
        if (array[key] === max) {
            console.log(key + ' -> ' + array[key] + 'times');
        };
    };
}
findMostFreqWord('in the middle of the night');
findMostFreqWord('Welcome to SoftUni. Welcome to Java. Welcome everyone.');
findMostFreqWord('Hello my friend, hello my darling. Come on, come here. Welcome, welcome darling.');