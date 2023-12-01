function solve() {
    let text = document.getElementById("input").value;
    let sentences = text.split(".");
    sentences = sentences
    .filter(s=>s.length>0)
    .map(s=>s+=".");

    let outputContainer = document.getElementById("output");
    while (sentences.length>0) {
        let p = document.createElement("p");
        p.textContent = sentences.splice(0,3).join("");
        outputContainer.appendChild(p);
    }
}