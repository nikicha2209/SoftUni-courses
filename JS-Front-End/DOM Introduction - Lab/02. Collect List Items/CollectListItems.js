    function extractText() {
    let items = document.getElementsByTagName("li");
    items = Array.from(items);
    let textArea = document.getElementById("result");
    let output = [];
    for (let index = 0; index < items.length; index++) {
        output.push(items[index].textContent);
    }

    textArea.textContent = output.join("\n");
}