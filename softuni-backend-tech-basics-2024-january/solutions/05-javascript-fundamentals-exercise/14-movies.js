function solve(commands) {
    'use strict';

    const movies = []

    for (const command of commands) {
        if (command.includes('addMovie')) {
            const movieName = command.replace('addMovie ', '')
            movies.push({
                name: movieName,
                director: '',
                date: '',
            })
        } else if (command.includes('directedBy')) {
            const movieName = command.substring(0, command.indexOf('directedBy')).trim()
            const directedBy = command.substring(command.indexOf('directedBy') + 'directedBy'.length).trim()

            const result = movies.find(movie => movie.name === movieName)

            if (!result) {
                // movies.push({
                //     name: movieName,
                //     date: '',
                //     director: directedBy,
                // })
            } else {
                result.director = directedBy
            }
        } else if (command.includes('onDate')) {
            const movieName = command.substring(0, command.indexOf('onDate')).trim()
            const onDate = command.substring(command.indexOf('onDate') + 'onDate'.length).trim()

            const result = movies.find(movie => movie.name === movieName)

            if (!result) {
                // movies.push({
                //     name: movieName,
                //     date: onDate,
                //     director: '',
                // })
            } else {
                result.date = onDate
            }
        }
    }

    movies
        .filter(movie => movie.date && movie.director && movie.name)
        .forEach(movie => console.log(JSON.stringify(movie)))
}

solve(
    [
        'addMovie Fast and Furious',
        'addMovie Godfather',
        'Inception directedBy Christopher Nolan',
        'Godfather directedBy Francis Ford Coppola',
        'Godfather onDate 29.07.2018',
        'Fast and Furious onDate 30.07.2018',
        'Batman onDate 01.08.2018',
        'Fast and Furious directedBy Rob Cohen'
    ]
)
