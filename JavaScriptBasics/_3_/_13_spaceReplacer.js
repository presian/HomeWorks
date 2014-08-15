function replaceSpaces(a) {
    var out = a.replace(/ /g, "&nbsp;");
    var out1 = a.replace(/ /g, "");
    return out + "\n" + out1;
}
console.log(replaceSpaces("But you were living in another world tryin' to get your message through"));