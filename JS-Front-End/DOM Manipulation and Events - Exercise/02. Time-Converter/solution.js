function attachEventsListeners() {

    //input fields
    let days = document.getElementById("days");
    let hours = document.getElementById("hours");
    let minutes = document.getElementById("minutes");
    let seconds = document.getElementById("seconds");

    //buttons
    let daysButton = document.getElementById("daysBtn");
    let hoursButton = document.getElementById("hoursBtn");
    let minutesButton = document.getElementById("minutesBtn");
    let secondsButton = document.getElementById("secondsBtn");

    //event listeners
    daysButton.addEventListener("click", clickedDaysButton);
    hoursButton.addEventListener("click", clickedHoursButton);
    minutesButton.addEventListener("click", clickedMinutesButton);
    secondsButton.addEventListener("click", clickedSecondsButton);


    function clickedDaysButton(e){
        hours.value = days.value*24;
        minutes.value = hours.value*60;
        seconds.value = minutes.value*60;
    }

    function clickedHoursButton(e){
        days.value = hours.value/24;
        minutes.value = hours.value*60;
        seconds.value = minutes.value*60;
    }

    function clickedMinutesButton(e){
        hours.value = minutes.value/60;
        days.value = hours.value/24;
        seconds.value = minutes.value*60;
    }

    function clickedSecondsButton(e){
        minutes.value = seconds.value/60;
        hours.value = minutes.value/60;
        days.value = hours.value/24;
    }
}