function solve(inputArray, step) {
    'use strict';

    const result = [];

    for (let index = 0; index < inputArray.length; index += step) {
        result.push(inputArray[index])
    }

    return result
}

console.log(solve(['5', '20', '31', '4', '20'], 2))
console.log(solve(['dsa', 'asd', 'test', 'tset'], 2))
console.log(solve(['1', '2', '3', '4', '5'], 6))
