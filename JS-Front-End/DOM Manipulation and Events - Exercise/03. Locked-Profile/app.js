function lockedProfile() {
    let showMoreButtons = Array.from(document.querySelectorAll("button"))


    for (const button of showMoreButtons) {
        button.addEventListener("click", clickedShowButton);
    }

    function clickedShowButton(e) {
        let button = e.currentTarget;
        let profile = button.parentNode;
        let radioButton = profile.querySelector(".profile input[type='radio'][value='unlock']");

        let additionalInfo = profile.querySelector("div");

        if (!radioButton.checked) {
            return;
        }

        if (button.textContent === "Show more") {
            additionalInfo.style.display = "block";
            button.textContent = "Hide it";
        } else if (button.textContent === "Hide it" && radioButton.checked) {
            additionalInfo.style.display = "none";
            button.textContent = "Show more";
        }
    }
}