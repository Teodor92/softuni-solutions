function solve(data) {
    'use strict';

    // Create an array to store the hero data
    let heroes = [];

    // Loop through the input data and parse each hero's information
    for (let heroInfo of data) {
        let [heroName, heroLevel, itemsStr] = heroInfo.split(' / ');

        // Convert heroLevel to a number
        heroLevel = parseInt(heroLevel);

        // Split itemsStr into an array of items
        let items = itemsStr.split(', ');

        // Create a hero object
        let hero = {
            name: heroName,
            level: heroLevel,
            items: items
        };

        // Push the hero object into the heroes array
        heroes.push(hero);
    }

    // Sort heroes by level in ascending order
    heroes.sort((a, b) => a.level - b.level);

    // Print the formatted hero data
    for (let hero of heroes) {
        console.log(`Hero: ${hero.name}`);
        console.log(`level => ${hero.level}`);
        console.log(`items => ${hero.items.join(', ')}`);
    }
}
