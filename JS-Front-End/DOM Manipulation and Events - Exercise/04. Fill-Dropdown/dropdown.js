function addItem() {
    let text = document.getElementById("newItemText");
    let valueText = document.getElementById("newItemValue");
    let menu = document.getElementById("menu");

    let newOption = document.createElement("option");
    newOption.textContent = text.value;
    newOption.value = valueText.value;
    menu.appendChild(newOption);
    text.value = "";
    valueText.value = "";

}