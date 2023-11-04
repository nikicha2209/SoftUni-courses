function findHashtags(text) {
    let pattern = /#[A-Za-z]+/g;
    let words = text.split(" ");
    for (const word of words) {
        if (word.match(pattern)) {
            let wordWithoutHashtag = word.substring(1);
            console.log(wordWithoutHashtag);
        }
    }
}

findHashtags('Nowadays everyone uses # to tag a #special word in #socialMedia');