function solve(numberOfPeople, typeOfPeople, dayOfTheWeek) {
    'use strict';

    let totalAmount = 0;

    if (typeOfPeople === 'Students') {
        if (dayOfTheWeek === 'Friday') {
            totalAmount = numberOfPeople * 8.45;
        } else if (dayOfTheWeek === 'Saturday') {
            totalAmount = numberOfPeople * 9.80;
        } else if (dayOfTheWeek === 'Sunday') {
            totalAmount = numberOfPeople * 10.46;
        }

        if (numberOfPeople >= 30) {
            totalAmount = totalAmount * 0.85;
        }
    } else if (typeOfPeople === 'Business') {
        if (dayOfTheWeek === 'Friday') {
            totalAmount = numberOfPeople * 10.90;
        } else if (dayOfTheWeek === 'Saturday') {
            totalAmount = numberOfPeople * 15.60;
        } else if (dayOfTheWeek === 'Sunday') {
            totalAmount = numberOfPeople * 16;
        }

        if (numberOfPeople >= 100) {
            const pricePerNight = totalAmount / numberOfPeople;
            totalAmount = pricePerNight * (numberOfPeople - 10);
        }
    } else if (typeOfPeople === 'Regular') {
        if (dayOfTheWeek === 'Friday') {
            totalAmount = numberOfPeople * 15;
        } else if (dayOfTheWeek === 'Saturday') {
            totalAmount = numberOfPeople * 20;
        } else if (dayOfTheWeek === 'Sunday') {
            totalAmount = numberOfPeople * 22.50;
        }

        if (numberOfPeople >= 10 && numberOfPeople <= 20) {
            totalAmount = totalAmount * 0.95;
        }
    }

    console.log(`Total price: ${totalAmount.toFixed(2)}`);
}

solve(30, "Students", "Sunday")
solve(40, "Regular", "Saturday")
