function demo(n, array) {
    let reverseArray = [];
    for (let i = 0; i < n; i++) {
        reverseArray.unshift(array[i]);
    }
    console.log(reverseArray.join(" "));
}