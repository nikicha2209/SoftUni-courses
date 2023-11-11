function isPalindrome(numbers) {
    for (let index = 0; index < numbers.length; index++) {
        let currentNumberAsString = numbers[index].toString();
        let reversedString = currentNumberAsString.split('').reverse().join('');

        if(currentNumberAsString==reversedString){
            console.log(true);
        } else{
            console.log(false);
        }
    }
}
