function cityInformation (city){
    let cities = Object.entries(city)
    
    cities.forEach(element => {
        console.log(`${element[0]} -> ${element[1]}`);
    });
}

