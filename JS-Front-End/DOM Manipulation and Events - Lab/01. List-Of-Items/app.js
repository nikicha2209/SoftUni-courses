function addItem() {
    let input = document.getElementById("newItemText").value;
    let newElement = document.createElement("li");
    newElement.textContent = input;
    let ulList = document.getElementById("items");
    ulList.appendChild(newElement);
}