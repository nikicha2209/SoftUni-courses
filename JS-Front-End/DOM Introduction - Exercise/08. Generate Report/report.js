function generateReport() {
    let output = [];
    let checkBoxes = Array.from(document.getElementsByTagName("input"));
    let indexesOfTheCheckedBoxes = [];

    for (let index = 0; index < checkBoxes.length; index++) {
        if (checkBoxes[index].checked) {
            indexesOfTheCheckedBoxes.push(index);
        }
    }

    let rowsCount = document.getElementsByTagName("tr").length - 1;

    for (let index = 1; index <= rowsCount; index++) {
        let currentRow = document.getElementsByTagName("tr")[index];
        let rowData = {};

        for (let checkBoxIndex of indexesOfTheCheckedBoxes) {

            let key = document.querySelector(`th:nth-child(${checkBoxIndex + 1})`).textContent;
            key = (key.charAt(0).toLowerCase() + key.slice(1)).trim();
            console.log(key);

            let value = currentRow.querySelector(`td:nth-child(${checkBoxIndex + 1})`).innerText;
            rowData[key] = value;
        }

        output.push(rowData);
    }

    let outputContainer = document.getElementById("output");
    outputContainer.value = JSON.stringify(output, null, 2);
}
