function solve(arrayOfRawData) {
    'use strict';

    const townData = []

    for (const rawData of arrayOfRawData) {
        const splitData = rawData.split(" | ")
        townData.push({
            town: splitData[0],
            latitude: parseFloat(splitData[1]).toFixed(2),
            longitude: parseFloat(splitData[2]).toFixed(2)
        })
    }

    townData.forEach((town) => console.log(town))
}

solve(['Sofia | 42.696552 | 23.32601', 'Beijing | 39.913818 | 116.363625'])
