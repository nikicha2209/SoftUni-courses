function search() {
   let towns = Array.from(document.getElementsByTagName("li"));
   towns.forEach(town => {
      town.style.fontWeight = "none";
      town.style.textDecoration = "none"
  });
   let searchedItem = document.getElementsByTagName("input")[0].value;
   let counter = 0;
   for (let index = 0; index < towns.length; index++) {
      if(towns[index].textContent.includes(searchedItem)){
         towns[index].style.fontWeight = "bold";
         towns[index].style.textDecoration = "underline"
         counter++;
      }
   }

   let outputContainer = document.getElementById("result");
   outputContainer.textContent = `${counter} matches found`;
}
