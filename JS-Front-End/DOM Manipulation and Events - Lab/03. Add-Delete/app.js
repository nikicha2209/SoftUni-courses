function addItem() {
    let input = document.getElementById("newItemText");

    let newListItem = document.createElement("li");
    newListItem.textContent = input.value;

    let deleteLink = document.createElement("a");
    deleteLink.textContent = "[Delete]"
    deleteLink.addEventListener('click', deleteElement);
    newListItem.appendChild(deleteLink);


    let uList = document.getElementById("items");
    uList.appendChild(newListItem);

    input.value = "";

    function deleteElement(e){
        let target = e.currentTarget;
        let parentElement = target.parentNode;
        parentElement.parentNode.removeChild(parentElement);
    }
}

