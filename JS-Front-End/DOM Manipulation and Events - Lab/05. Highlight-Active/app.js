function focused() {
    let input = Array.from(document.querySelectorAll("input"));
    for (const element of input) {
        element.addEventListener("focus", onFocus);
        element.addEventListener("blur", onBlur)
    }

    function onFocus(e){
        let element = e.currentTarget.parentNode;
        element.className = "focused";
    }

    function onBlur(e){
        let element = e.currentTarget.parentNode;
        element.classList.remove("focused")
    }
        
}