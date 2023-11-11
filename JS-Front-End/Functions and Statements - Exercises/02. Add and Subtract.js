function sumAndSubtract(firstNumber, secondNumber, thirdNumber) {
    let sum = (firstNumber, secondNumber) => {
        return firstNumber + secondNumber;
    }

    let subtract = (sum, thirdNumber) => {
        return sum - thirdNumber;
    }


    console.log(subtract(sum(firstNumber, secondNumber), thirdNumber));
}