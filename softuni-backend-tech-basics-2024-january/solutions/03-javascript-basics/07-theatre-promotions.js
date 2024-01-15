function solve(typeOfDay, age) {
    'use strict';

    if (age >= 0 && age <= 18) {
        if (typeOfDay === 'Weekday') {
            console.log('12$');
        } else if (typeOfDay === 'Weekend') {
            console.log('15$')
        } else if (typeOfDay === 'Holiday') {
            console.log('5$');
        }
    } else if (age > 18 && age <= 64) {
        if (typeOfDay === 'Weekday') {
            console.log('18$');
        } else if (typeOfDay === 'Weekend') {
            console.log('20$')
        } else if (typeOfDay === 'Holiday') {
            console.log('12$');
        }
    } else if (age > 64 && age <= 122) {
        if (typeOfDay === 'Weekday') {
            console.log('12$');
        } else if (typeOfDay === 'Weekend') {
            console.log('15$')
        } else if (typeOfDay === 'Holiday') {
            console.log('10$');
        }
    } else {
        console.log('Error!');
    }
}

solve('Holiday', 15)
