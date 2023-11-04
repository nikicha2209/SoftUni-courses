function findTheSubstring(searchedWord, text) {
    let wordsInText = text.split(" ");
    let found = false;
    wordsInText.forEach(word => {
        word = word.toLowerCase();
        if(word==searchedWord){
            console.log(word);
            found = true;
        }
    });

    if(!found){
        console.log(`${searchedWord} not found!`)
    }
}

findTheSubstring('javascript', 'JavaScript is the best programming language');