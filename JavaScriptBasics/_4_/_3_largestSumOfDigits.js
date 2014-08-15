function findLargestBySumOfDigits() {
    var sum = 0;
    var max = 0;
    var check = 0;
    var str = '';
    var element = 0;
    for (arg in arguments) {
        if (typeof arguments[arg] == 'string' || arguments[arg] instanceof String) {
            check++;
        } else if (arguments[arg] % 1 != 0) {
            check++;
        }
    };
    if (check > 0) {
        console.log('undefinde');
    } else {
        for (argum in arguments) {
            var num = Math.abs(arguments[argum])
            str = num.toString();
            for (var i = 0; i < str.length; i++) {
                sum = sum + parseInt(str[i]);
            }
            if (sum > max) {
                max = sum;
                element = arguments[argum];
            };
            sum = 0;
        };
        console.log(element);
    };
}
findLargestBySumOfDigits(5, 10, 15, 111);
findLargestBySumOfDigits(33, 44, -99, 0, 20);
findLargestBySumOfDigits('hello');
findLargestBySumOfDigits(5, 3.3);