function isPerfectNumber(number){
    let total = 0;
    for (let index = 1; index <= number/2; index++) {
        if(number%index==0){
            total+=index;
        }
    }

    if(total>0 && total==number){
        console.log("We have a perfect number!");
    } else{
        console.log("It's not so perfect.")
    }
}

isPerfectNumber(6);