
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
    const editbtn = document.getElementById(`edit_${id}`);
    if (editbtn.textContent == "編集") {
        editbtn.textContent = "登録";
    }
    else if (editbtn.textContent == "登録") {
        let input = cardText as HTMLInputElement;
        const data = { 'id': id, "text": input.value };
        const domain = document.getElementById("domain") as HTMLInputElement;
        const url = domain.value + 'card/OnPostCard';
        fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
            })
            .then(response => response.json())
            .then(data => {
                console.log('Success', data);
            })
            .catch((error) => {
                console.error('Error', error);
            });
        editbtn.textContent = "編集";
    }
}

function handleRegisterCard(): void {
    const space = document.getElementById("addCardSpace");
    const domain = document.getElementById("domain") as HTMLInputElement;
    const url = domain.value + 'card/OnGenerateCard';
    fetch(url)
        .then((response) => {
            return (response.text());
        })
        .then((html) => {
            space.innerHTML += html;
        })
        .catch((error) => {
            
        })
}