function variablesType(input) {
    console.log("My name: Pesho " + typeof(input[0]) + "\n" + //type is string
        "My age: 22 " + typeof(input[1]) + "\n" + //type is number
        "I am male: true " + typeof(input[2]) + "\n" + //type is boolean
        "My favorite foods are: fries, banana, cake " + typeof(input[3]) //type is object"
    );
}
variablesType(['Pesho', 22, true, ['fries', 'banana', 'cake']]);