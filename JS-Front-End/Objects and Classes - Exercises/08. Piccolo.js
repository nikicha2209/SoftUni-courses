function parkingSystem(input) {
    let parking = [];
    
    for (const element of input) {
        const [command, carNumber] = element.split(', ');
        if (command == "IN" && !parking.includes(carNumber)) {
            parking.push(carNumber);
        } else if (command == "OUT" && parking.includes(carNumber)) {
            let index = parking.indexOf(carNumber);
            parking.splice(index, 1);

        }
    }

    if (parking.length < 1) {
        console.log("Parking Lot is Empty");
    } else {
        console.log(parking.sort().join("\n"))
    }
}

parkingSystem(['IN, CA2844AA',
    'IN, CA1234TA',
    'OUT, CA2844AA',
    'IN, CA9999TT',
    'IN, CA2866HI',
    'OUT, CA1234TA',
    'IN, CA2844AA',
    'OUT, CA2866HI',
    'IN, CA9876HH',
    'IN, CA2822UU']
);