function validate() {
    let pattern = /([a-z]+)@([a-z]+)\.([a-z]+)/;
    let input = document.getElementById("email");
    input.addEventListener("change", onChange);

    function onChange(e){
        let element = e.currentTarget;
        if(!pattern.test(element.value)){
            element.classList.add("error");
            console.log(element.value);
        } else{
            element.classList.remove("error");  
        }
    }
}