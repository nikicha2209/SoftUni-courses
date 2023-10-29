function solve(groupOfPeople, typeOfGroup, dayOfWeek) {
    let price = 0;
    if (typeOfGroup == "Students") {
        if (dayOfWeek == "Friday") {
            price = 8.45;
        } else if (dayOfWeek == "Saturday") {
            price = 9.8;
        } else if (dayOfWeek == "Sunday") {
            price = 10.46;
        }
    } else if (typeOfGroup == "Business") {
        if (dayOfWeek == "Friday") {
            price = 10.9;
        } else if (dayOfWeek == "Saturday") {
            price = 15.6;
        } else if (dayOfWeek == "Sunday") {
            price = 16;
        }
    } else if (typeOfGroup == "Regular") {
        if (dayOfWeek == "Friday") {
            price = 15;
        } else if (dayOfWeek == "Saturday") {
            price = 20;
        } else if (dayOfWeek == "Sunday") {
            price = 22.5;
        }
    }

    if(groupOfPeople>=30 && typeOfGroup=="Students"){
        price=price*0.85;
    } if(groupOfPeople >=100 && typeOfGroup=="Business"){
        groupOfPeople-=10;
    } if(groupOfPeople>=10 && groupOfPeople<=20 && typeOfGroup=="Regular"){
        price=price*0.95;
    }

    console.log(`Total price: ${(groupOfPeople*price).toFixed(2)}`);
}


