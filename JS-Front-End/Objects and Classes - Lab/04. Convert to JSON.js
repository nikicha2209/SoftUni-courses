function converterToJSON(name, lastName, hairColor){
    let person = {name, lastName, hairColor};
    let inJSON = JSON.stringify(person);
    console.log(inJSON);
}