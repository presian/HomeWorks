var persons = [{
    firstname: 'George',
    lastname: 'Kolev',
    age: 32
}, {
    firstname: 'Bay',
    lastname: 'Ivan',
    age: 81
}, {
    firstname: 'Baba',
    lastname: 'Ginka',
    age: 40
}]

function findYoungestPerson(persons) {
    var min = 200;
    var fullName = '';
    for (person in persons) {
        if (min > persons[person].age) {
            min = persons[person].age;
            fullName = persons[person].firstname + " " + persons[person].lastname;
        };
    };

    console.log('The youngest person is ' + fullName);
}
findYoungestPerson(persons);