// export function sum(arr) {
//     let sum = 0;
//     for (let num of arr){
//         sum += Number(num);
//     }
//     return sum;
// }

// export const theNumberPi = Math.PI

function sum(arr) {
    let sum = 0;
    for (let num of arr){
        sum += Number(num);
    }
    return sum;
}

const theNumberPi = Math.PI


module.exports = {
    theNumberPi: theNumberPi,
    sum: sum
}
