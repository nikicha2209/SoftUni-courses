function solve(firstNumber, secondNumber){
    let result = '';
    let sum = 0;
    for(let i = firstNumber; i<=secondNumber; i++){
        result+=i + " ";
        sum+=i;
    }
    console.log(result.trim());
    console.log(`Sum: ${sum}`);
}