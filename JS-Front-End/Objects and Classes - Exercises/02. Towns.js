function printTownInfo(input) {
    input.forEach(element => {
        let townInfo = {};
        let tokens = element.split(" | ");
        let [town, latitude, longitude] = tokens;
        town = tokens[0];
        latitude = parseFloat(tokens[1]).toFixed(2);
        longitude = parseFloat(tokens[2]).toFixed(2);
        townInfo.town = town;
        townInfo.latitude = latitude;
        townInfo.longitude = longitude;
        console.log(townInfo);
    });
}

printTownInfo(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625']);