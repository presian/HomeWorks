// Write a script using jQuery that reads a JSON string which contains information 
// about cars and generates an HTML table.


var tableGenerator = (function() {

    var jason = [{
        "manufacturer": "BMW ",
        "model": "E92 320 i ",
        "year": 2011,
        "price": 50000,
        "class": "Family "
    }, {
        "manufacturer": "Porsche",
        "model": "Panamera",
        "year": 2012,
        "price": 100000,
        "class": "Sport"
    }, {
        "manufacturer": "Peugeot ",
        "model": "305",
        "year": 1978,
        "price": 1000,
        "class": "Family"
    }];

    function tableGenerator() {
        $.each(jason, function(_, item) {
            var row = $('<tr>').append(
                $('<td>').text(item.manufacturer),
                $('<td>').text(item.model),
                $('<td>').text(item.year),
                $('<td>').text(item.price),
                $('<td>').text(item.class)).appendTo('#table')
        })


    };

    return {
        TableGenerator: tableGenerator
    }
}());

$('#button').one('click', function() {
    tableGenerator.TableGenerator();
})
