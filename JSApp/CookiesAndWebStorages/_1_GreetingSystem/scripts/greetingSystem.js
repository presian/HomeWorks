$(document).ready(function() {

    if (!sessionStorage.visits) {
        sessionStorage.setItem('visits', 1);
        showSessionVisits(sessionStorage.getItem('visits'));
    } else {
        var visits = parseInt(sessionStorage.getItem('visits'));
        visits++;
        sessionStorage.setItem('visits', visits);
        showSessionVisits(visits);
    }

    if (!localStorage.firstVisit) {
        onFirstLoad();
    } else {
        var totalVisits = parseInt(localStorage.getItem('totalVisits'));
        totalVisits++;
        localStorage.setItem('totalVisits', totalVisits);
        showTotalVists(localStorage.getItem('totalVisits'));

        $('.result').append($('<input>').attr('type', 'button')
            .attr('value', 'Clear history about me!')
            .attr('id', 'clearButton').on('click', function(event) {
                event.preventDefault()
                localStorage.removeItem('firstVisit');
                localStorage.removeItem('name');
                localStorage.removeItem('totalVisits');
                onFirstLoad();
                event.stopPropagation();
            }));

        afterFirstLoad();
    };
})

function onFirstLoad() {
    if (!localStorage.totalVisits) {
        localStorage.setItem('totalVisits', 1);
    }
    $('.result').hide();
    localStorage.setItem('firstVisit', 'true');
    $('.wrapper').css('display', 'block');
    getName();
}

function afterFirstLoad() {
    $('.wrapper').hide();
    var result = $('.result');
    result.css('display', 'block');
    var name = localStorage.getItem('name');
    if (!name) {
        onFirstLoad();
    };
    $('<h2>Hello ' + name + '!</h2><br><p>(This botton clear information for first visit, name and total visit!)</p>')
        .prependTo('.result');
}

function getName() {
    $('#getNameButton').on('click', function(event) {
        event.preventDefault()
        var name = $('#getNameField').val();
        if (!name) {
            return alert('The name can not be empty.');
        }
        setName(name);
        event.stopPropagation();
    })
}

function setName(name) {
    localStorage.setItem('name', name);
    location.reload(true);
}

function showSessionVisits(visits) {
    $('.sessionVisits').text('Session vists:' + visits);
}

function showTotalVists(totalVisits) {
    $('.totalVisits').text('Total visits: ' + totalVisits);
}
