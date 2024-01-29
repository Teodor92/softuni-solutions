function demo(input) {
    let uniqueNames = {};
    input.forEach(element => {
        let keyValuePair = element.split(" ")
        let key = keyValuePair[0];
        let value = keyValuePair[1];
        uniqueNames[key] = value;
    });
    for (let key in uniqueNames) {
        console.log(`${key} -> ${uniqueNames[key]}`);
    }
}