function wordsTracker(input) {
    let dictionary = {};
    let [searchedWords, ...allWords]= input;
    searchedWords = searchedWords.split(" ");
    for (const searchedWord of searchedWords) {
        dictionary[searchedWord] = 0;
        for (const word of allWords) {
            if (searchedWord == word) {
                dictionary[searchedWord]++;
            }
        }
    }
        let entries = Object.entries(dictionary);
        entries.sort((a, b) => b[1] - a[1]);

        for (const [searchedWord, occurrences] of entries) {
            console.log(`${searchedWord} - ${occurrences}`);
        }

    }


wordsTracker([
    'is the', 
    'first', 'sentence', 'Here', 'is', 'another', 'the', 'And', 'finally', 'the', 'the', 'sentence']
    
)