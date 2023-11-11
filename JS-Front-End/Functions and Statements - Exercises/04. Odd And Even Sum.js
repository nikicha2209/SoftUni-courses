function oddAndEvenSum(number) {
    let oddSum = 0;
    let evenSum = 0;
    number = number.toString();

    for (let index = 0; index < number.length; index++) {
        if (number[index] % 2 == 0) {
            evenSum += Number(number[index]);
        } else {
            oddSum += Number(number[index]);
        }
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

oddAndEvenSum(1000435);
