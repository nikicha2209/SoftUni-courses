function getInfo() {
    const baseUrl = "http://localhost:3030/jsonstore/bus/businfo/";
    const button = document.getElementById("submit");
    const textBox = document.getElementById("stopId");
    const nameContainer = document.getElementById("stopName");
    const busesInfoContainer = document.getElementById("buses");

    button.addEventListener("click", async (e) => {
        e.preventDefault();
        
        try {
            // Clear the previous results
            nameContainer.textContent = "";
            busesInfoContainer.innerHTML = "";

            const response = await fetch(baseUrl + textBox.value);
            const data = await response.json();

            if (response.ok && data.name && data.buses) {
                nameContainer.textContent = data.name;

                for (const [busNumber, time] of Object.entries(data.buses)) {
                    let li = document.createElement("li");
                    li.textContent = `Bus ${busNumber} arrives in ${time} minutes`;
                    busesInfoContainer.appendChild(li);
                }
            } 
            
        } catch (error) {
            nameContainer.textContent = "Error";
        }
    });
}