function updateClock() {
    const now = new Date();
    const timeString = now.toLocaleTimeString();
    document.getElementById('timer').innerText = timeString;
}

function startExamination() {
    alert("Start Examination Functionality");
}

function playAudio() {
    alert("Play Audio Functionality");
}

function pauseAudio() {
    alert("Pause Audio Functionality");
}

setInterval(updateClock, 1000); // This updates the clock every second