function encodeAndDecodeMessages() {
    let encodeButton = document.querySelector("#main div:nth-child(1) button")
    encodeButton.addEventListener("click", encodeMessage);
    let lastReceivedMessageTextarea = document.querySelector("#main div:nth-child(2) textarea");
    function encodeMessage(e) {
        let message = document.querySelector("#main div:nth-child(1) textarea");
        let output = "";

        for (const char of message.value) {
            let asciiNumber = char.charCodeAt(0) + 1;
            output += String.fromCharCode(asciiNumber);
        }

        lastReceivedMessageTextarea.textContent = output;
        message.value = "";
    }

    let decodeButton = document.querySelector("#main div:nth-child(2) button");
    decodeButton.addEventListener("click", decodeMessage);

    function decodeMessage(e) {
        let message = document.querySelector("#main div:nth-child(2) textarea");
        let output = "";

        for (const char of message.value) {
            let asciiNumber = char.charCodeAt(0) - 1;
            output += String.fromCharCode(asciiNumber);    
        }

        message.textContent = output

    }


}