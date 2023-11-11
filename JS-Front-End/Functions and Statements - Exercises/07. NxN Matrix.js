function printAMatrix(n) {
    for (let index = 0; index < n; index++) {
        let output = "";
        let nAsString = n.toString();

        for (let index = 0; index < n; index++) {
            output += nAsString + " ";
        }

        console.log(output);
    }
}

printAMatrix(3);