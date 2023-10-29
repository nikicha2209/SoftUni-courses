function solve(number, firstOperation, secondOperation, thirdOperation, fourthOperation, fifthOperation, sixthOperation) {
    let num = parseInt(number);
    let array = [];
    array.push(firstOperation);
    array.push(secondOperation);
    array.push(thirdOperation);
    array.push(fourthOperation);
    array.push(fifthOperation);
    array.push(sixthOperation);

    for (let i = 0; i < 5; i++) {
        if(array[i] =='chop'){
            num=num/2;
        } else if(array[i] == 'dice'){
            num=Math.sqrt(num);
        } else if(array[i] == "spice"){
            num+=1;
        } else if(array[i] == "bake"){
            num*=3;
        } else if(array[i] == "fillet"){
            num=num-num*0.2;
        }
        console.log(num);
    }
}

solve('32', 'chop', 'chop', 'chop', 'chop', 'chop');