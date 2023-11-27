function calc() {
    let num1 = Number(document.getElementById("num1").value);
    let num2 = Number(document.getElementById("num2").value);
    let resultArea = document.getElementById("sum");
    let result = num1 + num2;
    resultArea.value = result;
}
