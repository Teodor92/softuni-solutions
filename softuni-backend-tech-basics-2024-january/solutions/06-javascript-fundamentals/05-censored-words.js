function demo(input, censoredWord) {
    let censored = input.replace(censoredWord, getStars(censoredWord));
    while (censored.includes(censoredWord)) {
        censored = censored.replace(censoredWord, getStars(censoredWord));
    }
    console.log(censored);
    function getStars(word) {
        return "*".repeat(word.length)
    }
}