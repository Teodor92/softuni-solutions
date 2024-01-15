// function solve(name, grade) {
//     console.log(`My name is: ${name} and my grade is: ${grade.toFixed(2)}`)
// }

// solve('Pesho!', 5.55555555)

function demo() {
    'use strict';

    let age = 2;
    age = '10';
    console.log(age);
    console.log('Type of age is ' + typeof age);

    let test;
    //const test2;
    console.log(test);
    console.log('Type of test is ' + typeof test);

    let test3 = 'Hello World';
    test3 = undefined;
    console.log(test3);
    console.log('Type of test3 is ' + typeof test3);

    let test4 = 2;
    test4 = null;

    // "as\"da"
    // 'as"da'

    console.log(test4);
    console.log('Type of test4 is ' + typeof test4);

    console.log(3 ** 2);

    let sample = 3;

    console.log(!!sample);

    if (sample) {
        console.log('I am in the if');
    }

    if (!sample) {
        console.log('There is no value in the sample variable');
    }

    let sample2 = '123';
    console.log(parseInt(sample2));
    console.log(+sample2);

    console.log('123', '33', 1, 33);
}

demo();

variableThatDoesNotExist = 3;
console.log(variableThatDoesNotExist);
