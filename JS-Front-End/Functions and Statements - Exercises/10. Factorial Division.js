function divideFactorials(firstNumber, secondNumber){
    let fisrtNumberFactorial = (firstNumber) =>{
        let firstFactorial = 1;
        for (let index = 1; index <= firstNumber; index++) {
            firstFactorial*=index;
        }

        return firstFactorial;
    }

    let secondNumberFactorial = (secondNumber) =>{
        let secondFactorial = 1;
        for (let index = 1; index <= secondNumber; index++) {
            secondFactorial*=index;
        }

        return secondFactorial;
    }

    console.log((fisrtNumberFactorial(firstNumber)/secondNumberFactorial(secondNumber)).toFixed(2));
}
