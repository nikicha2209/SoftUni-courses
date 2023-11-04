function revealWords (words, text){
    let everyWordInWords = words.split(", ");
    let everyWordInTheText = text.split(" ");

    for (let index = 0; index < everyWordInTheText.length; index++) {
        let wordInText = everyWordInTheText[index];
        
        for (let index = 0; index < everyWordInWords.length; index++) {
            let wordInWords = everyWordInWords[index];
            if(wordInText.length == wordInWords.length && wordInText.includes('*'.repeat(wordInText.length))){
                text = text.replace(wordInText, wordInWords);
            }
            
        }
    }

    console.log(text);
}
