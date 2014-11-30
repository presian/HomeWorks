var BOOK_URL = 'https://api.parse.com/1/classes/Book';
var PARSE_APP_ID = '9huU4QXZMscRcyWdrwdjtyg84qIvBXUrk5D0mYAm';
var PARSE_REST_API_KEY = 'tXZI43hpPBczab4OzpU29CsNm8e72yiJPT1UR6JI';

$(document).ready(function() {
    if (!localStorage.firstVisit) {
        localStorage.setItem('firstVisit', true);
        localStorage.setItem('editControls', '<form class="editControls">' +
            '<input type="text" id="titleEdit">' +
            '<input type="text" id="authorEdit">' +
            '<input type="text" id="isbnEdit">' +
            '<input type="button" value="Edit book" id="editButton">' +
            '</form>');
        localStorage.setItem('addControls', '<form class="addControls">' +
            '<input type="text" placeholder="Title" id="titleInput">' +
            '<input type="text" placeholder="Author" id="authorInput">' +
            '<input type="text" placeholder="ISBN" id="isbnInput">' +
            '<input type="button" value="Add book" id="addButton">' +
            '</form>');
    };
    onPageLoad();
})

function onPageLoad() {
    $('.editRow').hide();
    getLibraryDataFromServer();
}

function getLibraryDataFromServer() {
    $('.result').empty();
    $.ajax({
        headers: {
            "X-Parse-Application-Id": PARSE_APP_ID,
            "X-Parse-REST-API-Key": PARSE_REST_API_KEY
        },
        url: BOOK_URL,
        method: 'GET',
        contentType: 'application/json',
        success: function(data) {
            showBookList(data);
        },
        error: function() {
            errorMesage()
        }
    });
}

function addBook(title, author, isbn) {
    $.ajax({
        headers: {
            "X-Parse-Application-Id": PARSE_APP_ID,
            "X-Parse-REST-API-Key": PARSE_REST_API_KEY
        },
        url: BOOK_URL,
        method: 'POST',
        contentType: 'application/json',
        data: JSON.stringify({
            'title': title,
            'author': author,
            'isbn': isbn
        }),
        success: function() {
            onPageLoad();
        },
        error: function() {
            errorMesage();
        }
    });
}

function removeBook(bookId) {
    $.ajax({
        headers: {
            "X-Parse-Application-Id": PARSE_APP_ID,
            "X-Parse-REST-API-Key": PARSE_REST_API_KEY
        },
        url: BOOK_URL + '/' + bookId,
        method: 'DELETE',
        contentType: 'application/json',
        success: function() {
            onPageLoad();
        },
        error: function(xhr, textStatus, errorThrown) {
            errorMesage();
        }
    });
}

function editBook(title, author, isbn, bookId) {
    $.ajax({
        headers: {
            "X-Parse-Application-Id": PARSE_APP_ID,
            "X-Parse-REST-API-Key": PARSE_REST_API_KEY
        },
        url: BOOK_URL + '/' + bookId,
        method: 'PUT',
        contentType: 'application/json',
        data: JSON.stringify({
            'title': title,
            'author': author,
            'isbn': isbn
        }),
        success: function() {
            onPageLoad();
        },
        error: function() {
            errorMesage();
        }
    });
}

function showEditBookPanel(title, author, isbn, bookId) {
    $('.editRow').empty().html(localStorage.editControls);

    $('#editButton').on('click', function(event) {
        event.preventDefault();
        getDataFromEditControls($(this).data('bookId'));
        event.stopPropagation();
    })

    $('#titleEdit').attr('value', title).attr('placeholder', title);
    $('#authorEdit').attr('value', author).attr('placeholder', author);
    $('#isbnEdit').attr('value', isbn).attr('placeholder', isbn || 'ISBN');
    $('#editButton').data('bookId', bookId);
    //$('.addRow').hide(); // This hide add function when you want to edit book!
    $('.editRow').show();
}

function showBookList(data) {
    $('.addRow').empty().html(localStorage.addControls)
    $('#addButton').on('click', function(event) {
        event.preventDefault();
        getDataFromAddControls()
        event.stopPropagation();
    })

    var bookArray = data.results;
    var result = $('.result');
    if (bookArray.length === 0) {
        result.append($('<h3>').text('Has no books yet...'))
    } else {
        var headDiv = $('<div>').attr('class', 'bookListItem').attr('id', 'listHead');
        headDiv.append($('<div>').attr('class', 'cell').text('Title'))
            .append($('<div>').attr('class', 'cell').text('Author'))
            .append($('<div>').attr('class', 'cell').text('ISBN'))
            .append($('<div>').attr('class', 'cell'));

        result.append(headDiv);

        bookArray.forEach(function(book) {
            var editActionTarget = $('<div>').attr('class', 'editActionTarget');
            var row = $('<div>').attr('class', 'bookListItem');

            editActionTarget.append($('<div>').attr('class', 'cell').text(book.title))
                .append($('<div>').attr('class', 'cell').text(book.author))
                .append($('<div>').attr('class', 'cell').text(book.isbn)).on('click', function(event) {
                    event.preventDefault();
                    showEditBookPanel(book.title, book.author, book.isbn, book.objectId);
                    event.stopPropagation();
                });

            var buttonDiv = $('<div>').attr('class', 'cell')
                .append($('<button>').attr('class', 'deleteButton').text('Delete book!').on('click', function(event) {
                    event.preventDefault();
                    removeBook(book.objectId);
                    event.stopPropagation();
                }))

            row.append(editActionTarget).append($('<div>').attr('class', 'cell').append(buttonDiv));
            result.append(row);
        });
    }
}

function getDataFromAddControls() {
    var title = $('#titleInput').val();
    var author = $('#authorInput').val();
    var isbn = $('#isbnInput').val();

    if (!title || !author) {
        return alert('Every book must have title and author, they should be non-empty string!')
    }

    addBook(title, author, isbn);
}

function getDataFromEditControls(bookId) {
    var title = $('#titleEdit').val();
    var author = $('#authorEdit').val();
    var isbn = $('#isbnEdit').val();

    if (!title || !author) {
        return alert('Every book must have title and author, they should be non-empty string!')
    }
    // $('#titleEdit').val('');
    // $('#authorEdit').val('');
    // $('#isbnEdit').val('');
    editBook(title, author, isbn, bookId);
}

function errorMesage() {
    //TODO: error
    console.log('Error');
}
