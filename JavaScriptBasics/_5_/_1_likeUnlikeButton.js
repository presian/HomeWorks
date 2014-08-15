function changeButton() {
    likeButton = document.getElementById('like-button');
    var buttontext = likeButton.innerHTML;
    if (buttontext === 'Like') {
        buttontext = 'Unlike';
    } else {
        buttontext = 'Like';
    };
    likeButton.innerHTML = buttontext;
}
var likeButton = document.getElementById('like-button');
likeButton.addEventListener('click', changeButton, false);