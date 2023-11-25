function Employees(input){
    input.forEach(element => {
        let person = {};
        person.name = element;
        person.number = element.length;
        console.log(`Name: ${person.name} -- Personal Number: ${person.number}`);
    });
}

Employees(['Silas Butler', 'Adnaan Buckley', 'Juan Peterson', 'Brendan Villarreal'])