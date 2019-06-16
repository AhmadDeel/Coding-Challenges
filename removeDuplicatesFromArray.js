const removeDuplicates = arr => {
    return arr.filter((item, index) => {
        if (arr.filter(el => el === item).length <= 1) {
            return true;
        }
    });
};

const test1 = [1, 9, 8, 2, 7, 3, 2, 3, 1];
const test2 = [1, 2, 3, 4, 5, 6];
const test3 = [1, 2, 4, 2, 4, 1];
console.log(removeDuplicates(test1));
console.log(removeDuplicates(test2));
console.log(removeDuplicates(test3));