function solve(fruit, weight, pricePerKG){
    console.log(`I need $${(weight/1000*pricePerKG).toFixed(2)} to buy ${(weight/1000).toFixed(2)} kilograms ${fruit}.`);
}
