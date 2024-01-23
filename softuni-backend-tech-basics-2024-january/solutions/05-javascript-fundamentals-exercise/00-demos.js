const sampleArray = [133, 295, 311]

const arrayObject = {
    '0': 133,
    '1': 295,
    '2': 311
}

const sampleObject = { simpleProperty: 1, secondSimpleProperty: '2' }

// for (const item of sampleObject) {
//     console.log(item)
// }


for (const item in sampleObject) {
    console.log(item)
}
