app.controller('Problem_3', function($scope) {
    var dataObject = {
        'Name': 'Pesho',
        'Born': 'Asia',
        'BirthDate': '2006',
        'Live': 'Sofia Zoo'
    }

    var picUrl = 'http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg';

    var boldTextStyle = {
        border: 'none',
        color: 'rgb(43,61,79)',
        fontWeight: 'bolder',
        fontSize: '22px'
    }

    var ulStyle = {
        width: '90%'
    }

    var textStyle = {
        fontWeight: 'normal'
    }

    var notSorted = function(obj) {
        if (!obj) {
            return [];
        }
        return Object.keys(obj);
    }

    $scope.dataObject = dataObject;
    $scope.picUrl = picUrl;
    $scope.boldTextStyle = boldTextStyle;
    $scope.textStyle = textStyle;
    $scope.ulStyle = ulStyle;
    $scope.notSorted = notSorted
})
