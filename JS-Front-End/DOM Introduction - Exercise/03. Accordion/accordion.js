function toggle() {
    let button = document.querySelector(".button");
    let textToShow = document.getElementById("extra");

    if(button.textContent == "More"){
        button.textContent = "Less";
        textToShow.style.display = "block";
    } else{
        button.textContent = "More";
        textToShow.style.display = "none";
    }

   
}