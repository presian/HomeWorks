function playground() {
    console.log('Function length: ' + arguments.length);
    var output = '';
    for (var index = 0; index < arguments.length; index++) {
        output += 'Argument #'
            + (index + 1)
            + ' '
            + arguments[index]
            + ' '
            + (((typeof arguments[index]) == 'object'
                ? toString.call(arguments[index])
                : (typeof arguments[index]))
            +'\n');
    }
    output += '====================================\n'
                + 'this.THIS: ' + this.THIS
                + '\n\n\n';
    return output;
}

console.log(playground(0, 6.55, 'aaaa', true, {}, [2,5,6]));

console.log(playground.call({ THIS: 'This is function scope of THIS:' }, 123, 'Dancho', true));
THIS = 'This is global scope of THIS';
console.log(playground.apply(null,[1, 2, 3]));