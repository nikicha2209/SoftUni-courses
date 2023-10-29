function solve(number) {
    let numberAsString = number.toString();
    let sum = 0;
    let length = numberAsString.length;
    for (i = 0; i < length; i++) {
        sum += parseInt(numberAsString[i]);
    }
    console.log(sum);
}

solve(245678)