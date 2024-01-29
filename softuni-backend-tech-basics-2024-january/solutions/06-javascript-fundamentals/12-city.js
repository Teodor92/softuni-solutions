function demo(inputObject) {
    let entries = Object.entries(inputObject);
    entries.forEach(element => {
        console.log(`${element[0]} -> ${element[1]}`);
    });
}
