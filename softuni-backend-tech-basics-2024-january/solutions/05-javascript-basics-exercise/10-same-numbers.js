function solve(inputNumber) {
    'use strict';

    let totalSum = 0;
    let allDigitsAreTheSame = true;
    const firstDigit = inputNumber % 10;

    while (inputNumber > 0) {
        const currentDigit = inputNumber % 10;

        if (firstDigit != currentDigit) {
            allDigitsAreTheSame = false;
        }

        totalSum += currentDigit;
        inputNumber = Math.floor(inputNumber / 10);
    }

    console.log(allDigitsAreTheSame);
    console.log(totalSum);
}

solve(12345);
solve(22222);
