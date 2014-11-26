$(function() {
    var PARSE_APP_ID = "RHDFLFs4QbdndztzCyXETCVcsrLSyTRUJPFNWtUe";
    var PARSE_REST_API_KEY = "cP7XqCg29hOe9Zo6qbbKKVR4NCGqPEifE0rIKzqI";

    getCountries();

    function getCountries() {
        $.ajax({
            method: 'GET',
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            url: 'https://api.parse.com/1/classes/Country',
            success: function(data) {
                attachCountryEvents(data);
                attachTownEvents(data);
                showInHTML(data, '#country', 'Country');
            },
            error: errorMessage
        });
    }

    function attachCountryEvents(data) {
        addClassObject('country', data);
        editClassObject('country', data);
    }

    function attachTownEvents(data) {
        addClassObject('town', data);
        editClassObject('town', data);
    }

    function getTowns(countryId, countryName) {
        jQuery.ajax({
            url: 'https://api.parse.com/1/classes/Town?where={"country":{"__type":"Pointer","className":"Country","objectId":"' + countryId + '"}}',
            type: 'GET',
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            success: function(data) {
                showInHTML(data, '#town', 'Town', countryName, countryId);
            },
            error: errorMessage
        });
    }

    function showInHTML(data, panel, className, countryName, countryId) {
        var list = $('<ul>').attr('class', 'list');
        $(panel).empty();
        if (className === 'Town') {
            $('#wrapperTown').css('display', 'block')
            $(panel).empty();
            if (data.results.length === 0) {
                $('<h2>').text(countryName + ' have not towns yet...')
                    .data('countryName', countryName)
                    .data('townData', data)
                    .prependTo($(panel));
            } else {
                data.results.forEach(function(item) {
                    var town = $('<li>').attr('class', 'names').text(item.name + ' ')
                        .append($('<a href="#">')
                            .text('[Remove]')
                            .data('countryId', countryId)
                            .data('countryName', countryName)
                            .click(function() {
                                removeTown(countryId, countryName, item.objectId);
                            }));
                    town.appendTo(list);
                });
                list.prependTo($(panel));
                $('<h2>').text('Towns of ' + countryName).data('countryName', countryName).data('townData', data).prependTo($(panel));
            }
        } else {
            data.results.forEach(function(item) {
                var country = $('<li>').attr('class', 'names').text(item.name + ' ')
                    .append($('<a href="#">')
                        .text('[Remove]')
                        .data('countryId', item.objectId)
                        .click(function() {
                            removeCountry(item.objectId, item.name);
                        }))
                    .append(' / ')
                    .append($('<a href="#">')
                        .text('[Show towns]')
                        .data('countryId', item.objectId)
                        .data('countryName', item.name)
                        .click(function() {
                            getTowns(item.objectId, item.name);
                        }));
                country.appendTo(list);
            });
            list.prependTo($(panel));
            $('<h2>').text('Countries panel').prependTo($(panel));
        }
    }

    function addCountry(name, data) {
        console.log(name);
        var counter = 0;

        data.results.forEach(function(elem) {
            if (name === elem.name) {
                counter++;
            };
        });

        if (counter == 0) {
            jQuery.ajax({
                headers: {
                    "X-Parse-Application-Id": PARSE_APP_ID,
                    "X-Parse-REST-API-Key": PARSE_REST_API_KEY
                },
                url: 'https://api.parse.com/1/classes/Country',
                method: 'POST',
                data: JSON.stringify({
                    "name": name
                }),
                contentType: "application/json",
                success: function() {
                    location.reload(true);
                },
                error: errorMessage
            });
        } else {
            return alert('Country with this name already exist');
        }

    };

    function removeCountry(countryId, countryName) {
        jQuery.ajax({
            url: 'https://api.parse.com/1/classes/Country/' + countryId,
            type: 'DELETE',
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            success: function() {
                location.reload(true);
            },
            error: errorMessage
        });

    }

    function editCountry(currentName, newName, data) {
        var countryId;

        data.results.forEach(function(elem) {
            if (elem.name === currentName) {
                countryId = elem.objectId;
            }
        });

        if (!countryId) {
            return alert('This country is not exist');
        } else {
            jQuery.ajax({
                headers: {
                    "X-Parse-Application-Id": PARSE_APP_ID,
                    "X-Parse-REST-API-Key": PARSE_REST_API_KEY
                },
                url: 'https://api.parse.com/1/classes/Country/' + countryId,
                type: 'PUT',
                contentType: "application/json",
                data: JSON.stringify({
                    'name': newName
                }),
                success: function() {
                    location.reload(true);
                },
                error: errorMessage
            });
        }
    }


    function addTown(name, data) {
        var townData = $('#wrapperTown h2').data('townData');
        var counter = 0;

        townData.results.forEach(function(elem) {
            if (name === elem.name) {
                counter++;
            };
        });

        if (counter === 0) {
            var countryName = $('#wrapperTown h2').data('countryName');
            var countryId;
            data.results.forEach(function(elem) {
                if (elem.name === countryName) {
                    countryId = elem.objectId
                };
            });

            jQuery.ajax({
                headers: {
                    "X-Parse-Application-Id": PARSE_APP_ID,
                    "X-Parse-REST-API-Key": PARSE_REST_API_KEY
                },
                url: 'https://api.parse.com/1/classes/Town',
                method: 'POST',
                data: JSON.stringify({
                    "country": {
                        "__type": "Pointer",
                        "className": "Country",
                        "objectId": countryId
                    },
                    "name": name
                }),
                contentType: "application/json",
                success: function() {
                    getTowns(countryId, countryName)
                },
                error: errorMessage
            });
        } else {
            return alert('Town with this name already exist');
        }
    }


    function removeTown(countryId, countryName, townId) {
        jQuery.ajax({
            url: 'https://api.parse.com/1/classes/Town/' + townId,
            type: 'DELETE',
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            success: function() {
                getTowns(countryId, countryName)
            },
            error: errorMessage
        });
    }

    function editTown(currentName, newName, countryData) {
        var townData = $('#wrapperTown h2').data('townData');
        var countryName = $('#wrapperTown h2').data('countryName');
        var countryId;

        countryData.results.forEach(function(elem) {
            if (elem.name === countryName) {
                countryId = elem.objectId
            };
        });

        var townId;
        townData.results.forEach(function(elem) {
            if (elem.name === currentName) {
                townId = elem.objectId
            };
        });

        jQuery.ajax({
            headers: {
                "X-Parse-Application-Id": PARSE_APP_ID,
                "X-Parse-REST-API-Key": PARSE_REST_API_KEY
            },
            url: 'https://api.parse.com/1/classes/Town/' + townId,
            type: 'PUT',
            contentType: "application/json",
            data: JSON.stringify({
                "name": newName
            }),
            success: function() {
                getTowns(countryId, countryName)
            },
            error: errorMessage
        });
    }

    function addClassObject(kind, data) {
        var addButton = $(('#' + kind + 'AddButton'));
        addButton.on('click', function(event) {
            event.preventDefault();
            var name = $('#' + kind + 'AddName').val();
            if (!name) {
                return alert('The name should be non-empty string.');
                event.stopPropagation();
            };
            switch (kind) {
                case 'country':
                    addCountry(name, data);
                    event.stopPropagation();
                    break;
                case 'town':
                    addTown(name, data);
                    event.stopPropagation();
                    break;
            }
            event.stopPropagation();
        });
    }

    function editClassObject(kind, data) {
        var editButton = $('#' + kind + 'NameEditButton');
        editButton.on('click', function(event) {
            event.preventDefault();
            var currentName = $('#' + kind + 'CurrentName').val();
            var newName = $('#' + kind + 'NewName').val();
            if (!currentName || !newName) {
                return alert('The name should be non-empty string.');
            };
            switch (kind) {
                case 'country':
                    editCountry(currentName, newName, data);
                    break;
                case 'town':
                    editTown(currentName, newName, data);
                    break;
            }
            event.stopPropagation();
        })
    }

    function errorMessage() {
        return alert('Cannot load data.');
    }
})
