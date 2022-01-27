function handle(id) {
    var cardText = document.getElementById(id);
    if (cardText.id == id) {
        if (cardText.tagName == "P") {
            cardText.outerHTML = "<input id=\"".concat(id, "\" class=\"card-text cardclass\" value=\"").concat(cardText.textContent, "\" type=\"text\" />");
        }
        else if (cardText.tagName == "INPUT") {
            var cardInput = cardText;
            cardText.outerHTML = "<p id=\"".concat(id, "\"class=\"card-text cardclass\">").concat(cardInput.value, " </p>");
        }
    }
    var editbtn = document.getElementById("edit_".concat(id));
    if (editbtn.textContent == "編集") {
        editbtn.textContent = "登録";
    }
    else if (editbtn.textContent == "登録") {
        var input = cardText;
        var data = { 'id': id, "text": input.value };
        var domain = document.getElementById("domain");
        var url = domain.value + 'card/OnPostCard';
        fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        })
            .then(function (response) { return response.json(); })
            .then(function (data) {
            console.log('Success', data);
        })
            .catch(function (error) {
            console.error('Error', error);
        });
        editbtn.textContent = "編集";
    }
}
function handleRegisterCard() {
    var space = document.getElementById("addCardSpace");
    var domain = document.getElementById("domain");
    var url = domain.value + 'card/OnGenerateCard';
    fetch(url)
        .then(function (response) {
        return (response.text());
    })
        .then(function (html) {
        space.innerHTML += html;
    })
        .catch(function (error) {
    });
}
//# sourceMappingURL=card.js.map