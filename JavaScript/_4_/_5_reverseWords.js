function reverseWordsInString(str) {
    var words = str.split(' ');
    var out = '';
    for (word in words) {
        out = out + words[word].split('').reverse().join('') + ' ';
    };
    out = out.trim();
    console.log(out);
}
reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good isn’t it?');