function solve() {
    let textToChange = document.getElementById("text").value;
    let expectedCase = document.getElementById("naming-convention").value;
    textToChange = textToChange.toLowerCase();
    let output = "";
    let words = textToChange.split(" ");

    if (expectedCase == "Camel Case") {
        for (let index = 0; index < words.length; index++) {
            if (index == 0) {
                output += words[index]
            } else {
                output += words[index].charAt(0).toUpperCase() + words[index].slice(1);
            }

        }
    } else if (expectedCase == "Pascal Case") {
        for (let index = 0; index < words.length; index++) {
            output += words[index].charAt(0).toUpperCase() + words[index].slice(1);
        }
    } else {
        output = "Error!";
    }

    let outputContainer = document.getElementById("result");
    outputContainer.textContent = output;
}