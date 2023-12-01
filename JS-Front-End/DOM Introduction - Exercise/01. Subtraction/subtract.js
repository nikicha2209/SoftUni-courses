function subtract() {
    let firstNumber = document.getElementById("firstNumber").value;
    let secondNumber = document.getElementById("secondNumber").value;
    let outputContainer = document.getElementById("result");
    outputContainer.textContent = firstNumber - secondNumber;
}