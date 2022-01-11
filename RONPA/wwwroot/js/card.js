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