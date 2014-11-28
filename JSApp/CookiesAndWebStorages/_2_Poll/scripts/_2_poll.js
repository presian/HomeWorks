$(document).ready(function() {
    $('#clear').click(function(event) {
        event.preventDefault();
        clearStorages();
    })

    $('input[type="button"]').on('click', function(event) {
        event.preventDefault();
        getAnswers()
    });

    $('input[type="radio"]').on('click', function(event) {
        var radioOnChecked = event.target;
        localStorage.setItem(radioOnChecked.name, radioOnChecked.value);
    });

    if (!sessionStorage.firstVisit) {
        sessionStorage.setItem('firstVisit', true);
    }
    reloadAnswers();
})

function getAnswers() {
    sessionStorage.removeItem('firstVisit');
    window.clearInterval(setInter)
    sessionStorage.removeItem('timer');
    var questionNumber = 2;
    for (var i = 1; i <= questionNumber; i++) {
        var key = $('fieldset[name="question' + i + '"]>h2').text();
        var answer = $('input[type="radio"][name="question' + i + '"]:checked').val();
        sessionStorage.setItem(key, (answer || 'Empty vote!'));
    };

    if ($('#result').text() === '') {
        showAnswers()
    } else {
        return;
    };
}

function showAnswers() {
    var ul = $('<ul>').attr('class', 'answers').append('<p>').text('Your answers!');
    for (var key in sessionStorage) {
        $('<li>').text(key + ' -> ' + sessionStorage.getItem(key)).appendTo(ul);
    };
    ul.appendTo($('#result'))
    clearStorages();
}

function reloadAnswers() {
    for (var key in localStorage) {
        var val = localStorage.getItem(key);
        if (val !== null) {
            $('input[name="' + key + '"][value="' + val + '"]').click();
        };
    };
}

function endPoll() {
    getAnswers();
}

function clearStorages() {
    localStorage.clear();
    sessionStorage.clear();
}
