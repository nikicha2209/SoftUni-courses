function solve() {
  let generateButton = document.querySelector("#container #exercise button");
  generateButton.addEventListener("click", clickedGenerateButton);
  let input = document.querySelector("#exercise textarea");


  function clickedGenerateButton(e) {
    let data = JSON.parse(input.value);

    data.forEach(item => {
      let name = item.name;
      let img = item.img;
      let price = item.price;
      let decFactor = item.decFactor;
    

    let tbody = document.querySelector("tbody");
    let line = document.createElement("tr");
    tbody.appendChild(line);

    let firstTableData = document.createElement("td");
    let addingImg = document.createElement("img");
    addingImg.setAttribute("src", img);

    let secondTableData = document.createElement("td");
    let addingName = document.createElement("p");
    addingName.textContent = name;

    let thirdTableData = document.createElement("td");
    let addingPrice = document.createElement("p");
    addingPrice.textContent = price;

    let fourthTableData = document.createElement("td");
    let addingDecFactor = document.createElement("p");
    addingDecFactor.textContent = decFactor;

    let fifthTableData = document.createElement("td");
    let addingCheckBox = document.createElement("input");
    addingCheckBox.setAttribute("type", "checkbox");


    //adding elements 
    line.appendChild(firstTableData);
    firstTableData.appendChild(addingImg);

    line.appendChild(secondTableData);
    secondTableData.appendChild(addingName);

    line.appendChild(thirdTableData);
    thirdTableData.appendChild(addingPrice);

    line.appendChild(fourthTableData);
    fourthTableData.appendChild(addingDecFactor);

    line.appendChild(fifthTableData);
    fifthTableData.appendChild(addingCheckBox);
  });
  }

  let buyButton = document.querySelector("button:last-child");
  buyButton.addEventListener("click", clickedBuyButton);




  function clickedBuyButton(e) {
    let boughtFurniture = []
    let totalPrice = 0;
    let averageDecFactor = 0;


    let outputArea = document.querySelector("#exercise textarea:nth-child(5)");
    let elements = document.querySelectorAll("tbody tr");

    for (const element of elements) {
      let checkbox = element.querySelector("td:last-child input");

      if (checkbox.checked) {
        boughtFurniture.push(element.querySelector("td:nth-child(2) p").textContent);
        totalPrice += parseFloat(element.querySelector("td:nth-child(3) p").textContent);
        averageDecFactor += parseFloat(element.querySelector("td:nth-child(4) p").textContent);
      }
    }
    outputArea.textContent = `Bought furniture: ${boughtFurniture.join(", ")}`;
    outputArea.textContent += `\nTotal price: ${totalPrice.toFixed(2)}`;
    outputArea.textContent += `\nAverage decoration factor: ${averageDecFactor / boughtFurniture.length}`;
  }

}