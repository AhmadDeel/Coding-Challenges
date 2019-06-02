const formatNumberBasedOnString = string => {
    const newString = string.split('').map((char, index) => {
        let number, newChar;
        switch (char) {
            case 'A':
                number = + string[index + 1] + 1;
                newChar = (index < string.length - 1) ? `${number}` : '';
                break;
            case 'B':
                number = +string[index + 1] - 1;
                newChar = (index < string.length - 1) ? (number > -1) ? `${number}` : '0' : '';
                break;
            default:
                newChar = string[index];
                break;
        }
        return newChar;
    }).join('');
    const result = +newString;
    return result;
};

const string = 'A1A2B1B2A0B0';
const string2 = '2A53B24';
const string3 = '3A95A48A';
const string4 = '7A86B9B0';
console.log(formatNumberBasedOnString(string));
console.log(formatNumberBasedOnString(string2));
console.log(formatNumberBasedOnString(string3));
console.log(formatNumberBasedOnString(string4));