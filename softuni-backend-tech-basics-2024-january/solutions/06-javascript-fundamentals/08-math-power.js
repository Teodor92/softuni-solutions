function demo(number, power) {
    let finalNumber = number;
    for (let i = 1; i <= power - 1; i++) {
        finalNumber *= number;
    }
    console.log(finalNumber);
}