function solve(args) {
    'use strict';
    const numberOfBricks = parseInt(args[0], 10);
    const cartCapacity = parseInt(args[1], 10);
    const numberOfWorkers = parseInt(args[2], 10);

    const totalBricksPerTrip = numberOfWorkers * cartCapacity;
    const numberOfTrips = Math.ceil(numberOfBricks / totalBricksPerTrip);

    console.log(numberOfTrips);
}

solve([120, 2, 30]);
solve([355, 3, 10]);
solve([5, 12, 30]);
