function oddOccurrences(input) {
    input = input.toLowerCase();
    input = input.split(" ");
    let order = [];
    let occurrences = {};

    for (const word of input) {
        if (!occurrences.hasOwnProperty(word)) {
            occurrences[word] = 0;
            order.push(word)
        }

        occurrences[word]++;
    }


     let output = [];

     
    for (const word of order) {
        if (occurrences[word] % 2 === 1) {
            output.push(word);
        }
    }

    console.log(output.join(" "));

}

oddOccurrences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');