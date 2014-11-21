// Create a slideshow using jQuery:
// •	The slider should have several slides
// •	Only one slide is visible at a time
// •	Each slide can contain HTML code
// 		o	It can contain images, forms, divs, headers, links, etc.
// •	Implement functionality for the visible slide to automatically change to the next one after 5 seconds
// •	Create buttons for next and previous slide

$(document).ready(function() {
    var index = 1;

    (function() {
        changeSlide('+');
        setTimeout(arguments.callee, 5000);
    })();

    function changeSlide(sign) {
        $('#slideShowWindow').css('background-image', "url('./pictures/" + index + ".jpg')");

        switch (sign) {
            case '+':
                index++;
                if (index > 6) {
                    index = 1;
                };
                break;
            case '-':
                index--;
                if (index < 1) {
                    index = 6;
                };
                break;
            default:
                break;
        }
    }

    (function clickedButton() {
        var leftArrow = $('#leftArrow').click(function() {
            changeSlide('-');
        });
        console.log(leftArrow);
        var rightArrow = $('#rightArrow').click(function() {
            changeSlide('+');
        });
    })();
})
