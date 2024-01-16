const sampleArray = [1, 2, 3, 4];

const proccedArray = sampleArray.map((x) => x * 10);
console.log(proccedArray)

const filteredArray = sampleArray.filter((x) => x > 2);
console.log(filteredArray);

const hasTheNumber4 = sampleArray.some(x => x == 4);
console.log(hasTheNumber4)

const sumArray = sampleArray.reduce((accumulator, currentElement) => accumulator + currentElement);
console.log(sumArray);

console.error('Big ERROR!')
