function Initialize () {
    var button = document.querySelector("#consent");
    button.addEventListener("click", function (event) {
        document.cookie = button.dataset.cookieString;
        document.querySelector("#consent").style.display = 'none';
    }, false);
}