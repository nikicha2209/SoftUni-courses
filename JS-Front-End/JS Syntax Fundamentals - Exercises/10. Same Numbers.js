function solve(number) {
    let numberAsString = number.toString();
    let sum = 0;
    let isTheSame = true;
    let length = numberAsString.length;
    for (let i = 0; i < numberAsString.length; i++) {
        if (i == (numberAsString.length - 1)) {
            break;
        } else {
            if (parseInt(numberAsString[i]) != parseInt(numberAsString[i + 1])) {
                isTheSame = false;
            }
        }

        sum += parseInt(numberAsString[i]);
    }

    sum += parseInt(numberAsString[length - 1])


    if (isTheSame) {
        console.log(true);
    } else {
        console.log(false);
    }

    console.log(sum);
}

solve(1234)