function solve(input) {
    'use strict';

    const parkingLot = new Set();

    for (const entry of input) {
        const [direction, carNumber] = entry.split(', ');

        if (direction === 'IN') {
            parkingLot.add(carNumber);
        } else if (direction === 'OUT') {
            parkingLot.delete(carNumber);
        }
    }

    if (parkingLot.size === 0) {
        console.log('Parking Lot is Empty');
    } else {
        const sortedCarNumbers = Array.from(parkingLot).sort();
        console.log(sortedCarNumbers.join('\n'));
    }
}
