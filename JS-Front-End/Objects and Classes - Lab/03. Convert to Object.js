function jsonToObject(json){
    let obj = JSON.parse(json);
    let infoArray = Object.entries(obj);
    infoArray.forEach(element => {
        console.log(`${element[0]}: ${element[1]}`);
    });
}

