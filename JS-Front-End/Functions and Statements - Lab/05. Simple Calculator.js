function calculator(a, b, operator) {
    const operations = {
        multiply: (a, b) => a * b,
        divide: (a, b) => a / b,
        add: (a, b) => a + b,
        subtract: (a, b) => a - b,
    }

    console.log(operations[operator](a,b));
}

calculator(5, 5,'multiply');
