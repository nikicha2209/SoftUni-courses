function printTheSmallestNumber(numOne, numTwo, numThree) {
    let smallest;
    if (numOne < numTwo && numOne < numThree) {
        smallest = numOne;
    } else if (numTwo < numOne && numTwo < numThree) {
        smallest = numTwo;
    } else {
        smallest = numThree;
    }

    console.log(smallest);
}