function demo(product, quantity) {
    if (product === "coffee") {
        console.log((1.5 * quantity).toFixed(2));
    }
    else if (product === "water") {
        console.log((1.0 * quantity).toFixed(2));
    }
    else if (product === "coke") {
        console.log((1.4 * quantity).toFixed(2));
    }
    else if (product === "snacks") {
        console.log((2.0 * quantity).toFixed(2));
    }
}