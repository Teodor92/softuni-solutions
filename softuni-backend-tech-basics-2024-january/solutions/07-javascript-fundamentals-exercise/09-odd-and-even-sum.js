function solve(inputNumber) {
    'use strict';

    let oddSum = 0;
    let evenSum = 0;

    while (inputNumber > 0) {
        const currentDigit = inputNumber % 10

        if (currentDigit % 2 === 0) {
            evenSum += currentDigit
        } else {
            oddSum += currentDigit
        }

        inputNumber = Math.floor(inputNumber / 10)
    }

    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`)
}

solve(1000435)
