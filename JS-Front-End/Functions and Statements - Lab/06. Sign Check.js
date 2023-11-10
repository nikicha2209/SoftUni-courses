function signCheck(...numbers) {
    let negativeNumbers = 0;
    for (const number of numbers) {
        if (number < 0) {
            negativeNumbers++;
        }
    }
    if (negativeNumbers % 2 == 0) {
        console.log("Positive");
    } else {
        console.log("Negative");
    }

    // console.log(numbers.filter(n => n < 0).length % 2 == 0 ? "Positive" : "Negative")
}

//solved without multiplying in 2 different ways 

