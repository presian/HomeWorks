function findNthDigit(arr) {
    var n = arr[0];
    var num = arr[1].toString().split('');
    for (var i = 0; i < num.length; i++) {
        if ((num[i] === '.') || (num[i] === '-')) {
            num.splice(i, 1);
        }
    };
    if (n > num.length) {
        console.log('The number doesn’t have ' + n + ' digits');
    } else {
        var out = num[num.length - n]
        switch (out) {
            case '0':
                console.log('zero');
                break;
            case '1':
                console.log('one');
                break;
            case '2':
                console.log('two');
                break;
            case '3':
                console.log('three');
                break;
            case '4':
                console.log('four');
                break;
            case '5':
                console.log('five');
                break;
            case '6':
                console.log('six');
                break;
            case '7':
                console.log('seven');
                break;
            case '8':
                console.log('eight');
                break;
            case '9':
                console.log('nine');
                break;
        }
    };

}
findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);