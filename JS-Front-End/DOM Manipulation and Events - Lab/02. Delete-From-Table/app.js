function deleteByEmail() {
    let searchedEmail = document.querySelector("input");
    let rows = document.querySelectorAll("tbody tr")
    let outputContainer = document.getElementById("result");
    let found = false;

    for (let row = 0; row < rows.length; row++) {
        let emails = rows[row].querySelector("td:nth-child(2)");
        console.log(emails);
        if (emails.textContent == searchedEmail.value) {
            rows[row].parentNode.removeChild(rows[row]);
            outputContainer.textContent = "Deleted.";
            found = true;
        }
    }

    if (!found) {
        outputContainer.textContent = "Not found.";
    }

}