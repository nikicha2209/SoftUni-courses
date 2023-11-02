function solve(text, searchedWord){
    let counter = 0;
    let textAsAnArray = text.split(" ");
    for (const word of textAsAnArray) {
        if(word==searchedWord){
            counter++;
        }
    }

    console.log(counter);
}