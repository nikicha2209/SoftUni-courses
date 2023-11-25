function inventory(input){
    class Hero{
        constructor(name, level, items){
            this.name = name;
            this.level = level;
            this.items = items;
        }
    }

    let array = [];
    input.forEach(element => {
        [heroName, heroLevel, items] = element.split(" / ");
        let hero = new Hero(heroName, heroLevel, items);
        array.push(hero);
    });
    
    array.sort((a, b) => a.level - b.level);
    
    for (const hero of array) {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items}`);

    }
    
}

inventory([
    'Isacc / 25 / Apple, GravityGun',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'
    ]
    );