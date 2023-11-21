function addressBook(input) {
    let addressBook = {};
    input.forEach(element => {
        let tokens = element.split(":");
        [name, address] = tokens;
        addressBook[name] = address;
    });

    addressBook = Object.entries(addressBook);
    addressBook.sort((a, b) => a[0].localeCompare(b[0]));

    for (let [key, value] of addressBook) {
        console.log(`${key} -> ${value}`);
    }
}
