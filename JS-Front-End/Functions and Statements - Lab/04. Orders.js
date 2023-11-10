function orders(product, quantity) {
    let basePrice;

    switch (product) {
        case "water":
            basePrice = 1;
            break;
        case "coffee":
            basePrice = 1.5;
            break;
        case "coke":
            basePrice = 1.4;
            break;
        case "snacks":
            basePrice = 2;
            break;
    }

    return ((basePrice * quantity).toFixed(2));
}

