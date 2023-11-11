function printLoadingBar(number) {
    if (number != 100) {
        console.log(`${number}% [${'%'.repeat(number / 10)}${".".repeat((100 - number) / 10)}]`);
        console.log("Still loading...");
    } else{
        console.log("100% Complete!");
        console.log(`[${'%'.repeat(number/10)}]`);
    }
}

printLoadingBar(50);