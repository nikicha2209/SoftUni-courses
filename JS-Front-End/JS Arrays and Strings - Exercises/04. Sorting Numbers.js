function sortingNumbers(array) {
    let sortedArray = array.sort((a, b) =>  a - b );
    let resultArray = [];
    let arrayLength = array.length;

    for (let index = 0; index < arrayLength; index++) {
        if(index%2==0){
            resultArray.push(sortedArray.shift());
        } else{
            resultArray.push(sortedArray.pop())
        }
    }

    return resultArray;
}
