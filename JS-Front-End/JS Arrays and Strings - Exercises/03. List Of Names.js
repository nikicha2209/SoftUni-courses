function sortingNames(list) {
    list.sort((a, b) => {
        return a.localeCompare(b)
    });


    for (let index = 1; index <= list.length; index++) {
        console.log(`${index}.${list[index-1]}`);        
    }
}

sortingNames(["John", "Bob", "Christina", "Ema"])