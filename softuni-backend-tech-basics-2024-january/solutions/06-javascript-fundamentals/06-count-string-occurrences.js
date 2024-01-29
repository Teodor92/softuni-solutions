function demo(text, word) {
    let words = text.split(' ');
    let count = 0;
    words.forEach(element => {
        if (element === word) {
            count++;
        }
    });
    console.log(count);
}
