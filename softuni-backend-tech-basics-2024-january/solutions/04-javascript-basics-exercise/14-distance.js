function solve(args) {
    'use strict';

    let speed = Number(args[0]);
    const firstTime = Number(args[1]);
    const secondTime = Number(args[2]);
    const thirdTime = Number(args[3]);

    const firstTimeInHours = firstTime / 60;
    const secondTimeInHours = secondTime / 60;
    const thirdTimeInHours = thirdTime / 60;

    let distance = speed * firstTimeInHours;
    speed = speed * 1.1;
    distance = distance + (speed * secondTimeInHours);
    speed = speed * 0.95;
    distance = distance + (speed * thirdTimeInHours);

    console.log(distance.toFixed(2));
}

solve([90, 60, 70, 80]);
solve([140, 112, 75, 190]);
