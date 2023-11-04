function splitTheWords(text){
    let pattern = /[A-Z][a-z]*/g;
    let array = text.match(pattern);
    console.log(array.join(", "));
}