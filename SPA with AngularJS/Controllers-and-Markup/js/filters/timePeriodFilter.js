app.filter('perodFilter', function() {
    return function periodFilter(elements, choice) {
        var timeNow = new Date().getTime();
        var day = 24 * 60 * 60 * 1000;
        var startTime;
        switch (choice) {
            case 'day':
                startTime = timeNow - day;
                break;
            case 'week':
                startTime = timeNow - day * 7;
                break;
            case 'month':
                startTime = timeNow - day * 30;
                break;
            case 'year':
                startTime = timeNow - day * 365;
                break;
            default:
                startTime = 0;
                break;
        }
        var result = [];
        for (var i = 0; i < elements.length; i++) {
            var elementTime = elements[i].date.getTime();
            if (elementTime <= timeNow && elementTime >= startTime) {
                result.push(elements[i]);
            };

        };
        return result;
    }
})
