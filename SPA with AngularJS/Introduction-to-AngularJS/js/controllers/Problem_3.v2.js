app.controller('Problem_3.v2', function($scope) {
    var dataObject = {
        'Name': 'Pesho',
        'Born': 'Asia',
        'BirthDate': '2006',
        'Live': 'Sofia Zoo'
    }
    dataObject.url = 'http://tigerday.org/wp-content/uploads/2013/04/tiger.jpg';

    var style = {
        all: {

            backgroundColor: 'rgb(202, 202, 202)',
            color: 'rgb(43,61,79)',
            fontFamily: 'Clibry',
            fontWeight: 'Bolder',
            fontSize: '22px'
        },
        outDiv: {
            border: 'none',
            width: '100%'
        },
        inDiv: {
            border: 'none',
            width: '45%'
        },
        img: {
            width: '100%'
        },
        ul: {
            width: '100%'
        },
        h1: {
            color: 'black'
        }
    }

    $scope.style = style;
    $scope.dataObject = dataObject;
})
