function sumTable() {
    let rows = document.querySelectorAll("table tr");
    let sum = 0;
    for (let index = 1; index < rows.length; index++) {
        let element = rows[index].children;
        let number = Number(element[1].textContent);
        console.log(number);
        sum+=number;
    }

    let outputContainer = document.getElementById("sum");
    outputContainer .textContent = sum

}