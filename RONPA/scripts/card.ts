
function handle(id: string): void {
    let cardText = document.getElementById(id);
    
    if (cardText.id == id) {
        if (cardText.tagName == "P") {
            cardText.outerHTML = `<input id="${id}" class="card-text cardclass" value="${cardText.textContent}" type="text" />`;
        }
        else if (cardText.tagName == "INPUT") {
            let cardInput = cardText as HTMLInputElement;
            cardText.outerHTML = `<p id="${id}"class="card-text cardclass">${cardInput.value} </p>`;
        }
    }
}

function handleRegisterCard(): void {
    const domain = document.getElementById("domain");

}