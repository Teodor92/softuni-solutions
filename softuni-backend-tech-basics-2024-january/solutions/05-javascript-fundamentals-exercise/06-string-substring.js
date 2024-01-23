function solve(wordToSearch, textForSearching) {
    'use strict';

    const hasWord = textForSearching
        .toLowerCase()
        .split(' ')
        .includes(wordToSearch)

    if (hasWord) {
        console.log(wordToSearch)
    } else {
        console.log(`${wordToSearch} not found!`)
    }
}

solve('javascript',
'JavaScript is the best programming language')
solve('python',
'JavaScript is the best programming language'
)
