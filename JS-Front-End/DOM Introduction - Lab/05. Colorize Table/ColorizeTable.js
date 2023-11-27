function colorize() {
    let elements = document.querySelectorAll("tr");
    let elementsArray = Array.from(elements);
    for (let index = 1; index < elementsArray.length; index++) {
        if(index%2==1){
            elementsArray[index].style.background="teal";
        }
    }
}