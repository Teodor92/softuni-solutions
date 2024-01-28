function solve(firstNumber, secondNumber, thirdNumber) {
    'use strict';

    // function sum(first, second) {
    //     return first + second
    // }

    const sum = (first, second) => first + second
    // const sumAlternative = function(first, second) {
    //     return first + second
    // }
    const subtract = (first, second) => first - second

    const result = subtract(sum(firstNumber, secondNumber), thirdNumber)

    console.log(result)
}
