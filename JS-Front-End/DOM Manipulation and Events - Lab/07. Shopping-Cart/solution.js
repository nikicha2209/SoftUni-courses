function solve() {
    let products = {};
    let buttons = Array.from(document.getElementsByClassName("add-product"));
    let textArea = document.querySelector("textarea");

    for (const button of buttons) {
        button.addEventListener("click", clickedAddButton)
    }

    function clickedAddButton(e) {
        let currentProduct = e.currentTarget.parentNode.parentNode;
        let productDescription = currentProduct.querySelector(":nth-child(2)");
        let productName = productDescription.querySelector(":nth-child(1)").textContent;
        let price = parseFloat(currentProduct.querySelector(":nth-child(4)").textContent);
        if (products.hasOwnProperty(productName)) {
            products[productName] += parseFloat(price.toFixed(2));
        } else {
            products[productName] = parseFloat(price.toFixed(2));
        }
        textArea.textContent += `Added ${productName} for ${price.toFixed(2)} to the cart.\n`;
    }

    let checkoutButton = document.getElementsByClassName("checkout")[0];
    checkoutButton.addEventListener("click", clickedCheckoutButton);

    function clickedCheckoutButton(e) {
        let allBoughtProducts = Object.keys(products);
        let totalPrice = Object.values(products);
        let sum = totalPrice.reduce((acc, val) => acc + val, 0);
        textArea.textContent += `You bought ${allBoughtProducts.join(", ")} for ${sum.toFixed(2)}.`;
        buttons.forEach(button => {
            button.disabled = true;
        })
        checkoutButton.disabled = true;
    }
}