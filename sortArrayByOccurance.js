const arr = [4,1,2,3,2,3,1,1,5,4,5,6,7];
const arr2 = ['a','b','a','c','b','d','b','d','e','c','z','f','a'];

const sortArray = arr => {
    let numbersWithRepeat = [];
    arr.forEach(element => {
        const pair = numbersWithRepeat.find(p => p.key == element);
        if(pair) {
            pair.value++;
        } else {
            const pair = {key: element, value: 1};
            numbersWithRepeat.push(pair);
        }
    });
    numbersWithRepeat.sort((a,b) => (a.value > b.value) ? -1 : (a.value < b.value) ? 1 : 0);
    console.log(numbersWithRepeat);
    let resultArray = [];
    for(const pair of numbersWithRepeat) {
        for(let i = 0; i < pair.value; i++) {
            resultArray.push(pair.key);
        }
    }
    return resultArray;
}
const result = sortArray(arr);
const result2 = sortArray(arr2);
console.log('\nfinal result: ', result)
console.log('\nfinal result: ', result2)