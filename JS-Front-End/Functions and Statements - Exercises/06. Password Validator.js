function isPasswordValid(password) {
    let isValid = true;
    if (password.length < 6 || password.length > 10) {
        isValid=false;
        console.log("Password must be between 6 and 10 characters");
    }

    let patternOnlyLettersAndDigits = /^[A-Za-z0-9]+$/g;
    if(!patternOnlyLettersAndDigits.test(password)){
        isValid=false;
        console.log("Password must consist only of letters and digits");
    }

    let patternAtLeastTwoDigits = /\d{2,}/g;
    if(!patternAtLeastTwoDigits.test(password)){
        isValid=false;
        console.log("Password must have at least 2 digits");
    }

    

    if(isValid){
        console.log("Password is valid");
    }
}
