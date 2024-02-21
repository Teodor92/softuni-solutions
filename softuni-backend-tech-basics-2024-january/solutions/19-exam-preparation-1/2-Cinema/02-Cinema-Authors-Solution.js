function cinema(input) {
    const numberOfMovies = parseInt(input[0], 10);

    const allMovies = input.slice(1, numberOfMovies + 1)
    const allCommands = input.slice(numberOfMovies + 1)

    for (let index = 0; index < allCommands.length; index += 1) {
        const rawParams = allCommands[index].split(' ');
        const commandName = rawParams[0];



        if (commandName === 'Sell') {
            const soldMovie = allMovies.shift();
            console.log(`${soldMovie} ticket sold!`);
        } else if (commandName === 'Add') {
            const movieTitleToAdd = allCommands[index].slice(4);

            if (!movieTitleToAdd) {
                continue;
            }

            allMovies.push(movieTitleToAdd);
        } else if (commandName === 'Swap') {
            const firstIndex = parseInt(rawParams[1], 10);
            const secondIndex = parseInt(rawParams[2], 10);

            if (isNaN(firstIndex) || firstIndex < 0 || firstIndex >= allMovies.length) {
                continue;
            }

            if (isNaN(secondIndex) || secondIndex < 0 || secondIndex >= allMovies.length) {
                continue;
            }

            const movieOnFirstIndex = allMovies[firstIndex];
            allMovies[firstIndex] = allMovies[secondIndex];
            allMovies[secondIndex] = movieOnFirstIndex;

            console.log("Swapped!");
        } else if (commandName === "End") {
            break;
        }
    }

    if (allMovies.length) {
        console.log(`Tickets left: ${allMovies.join(', ')}`)
    } else {
        console.log("The box office is empty");
    }
}

// cinema(['3', 'Avatar', 'Titanic', 'Joker', 'Sell', 'Swap 0 1', 'End'])

// cinema(['5', 'The Matrix', 'The Godfather', 'The Shawshank Redemption', 'The Dark Knight', 'Inception', 'Add The Lord of the Rings', 'Swap 1 4', 'End'])

cinema(['3', 'Star Wars', 'Harry Potter', 'The Hunger Games', 'Sell', 'Sell', 'Sell', 'End'])