function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let rows = document.getElementsByTagName("tr");
      for (let index = 1; index < rows.length; index++) {
         if (rows[index].classList.contains("select")) {
            rows[index].classList.remove("select");

         }
         let searchedItem = document.getElementById("searchField").value;
         for (let index = 1; index < rows.length; index++) {
            if (rows[index].textContent.includes(searchedItem)) {
               rows[index].className = "select";
            }
         }

      }
   }
}