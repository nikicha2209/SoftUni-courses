function create(words) {

   for (const word of words) {
      let div = document.createElement("div");
      let paragraph = document.createElement("p");
      paragraph.textContent = word;
      paragraph.style.display = "none";
      let content = document.getElementById("content");
      
      content.appendChild(div);
      div.appendChild(paragraph);

      div.addEventListener("click", clickedDiv);
      function clickedDiv(e){
         paragraph.style.display = "block";
      }
   }
}