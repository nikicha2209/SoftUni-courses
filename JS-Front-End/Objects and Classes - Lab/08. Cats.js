function getCats(input) {
    class Cat {
        constructor(name, age) {
            this.name = name;
            this.age = age;
        }

        meow() {
            console.log(`${name}, age ${age} says Meow`);
        }
    }

    input.forEach(element => {
        element = element.split(" ");
        [name, age] = element;
        let cat = new Cat(name, age);
        cat.meow();
    });
}

