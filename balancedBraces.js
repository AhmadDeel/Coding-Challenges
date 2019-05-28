const s = `function isBalanced(s, braces) {
            if(!s.length) {
            }
        }`;

const definedOpenBraces="{[(<";
const definedCloseBraces="}])>";

let braces = [];
let stage = 0;

function isBalanced(s, braces) {
    filterString = definedCloseBraces + definedOpenBraces;
    if(!s.length)
        return;
    let firstOccurance = 0;
    for(let i=0; i < s.length; i++) {
        if(definedOpenBraces.indexOf(s[i]) > -1) {
            firstOccurance = i;
            braces.push(s[i]);
            stage++;
            console.log(stage, braces);
            break;
        } else if (definedCloseBraces.indexOf(s[i]) > -1) {
            firstOccurance = i;
            index = definedCloseBraces.indexOf(s[i]);
            if(braces[braces.length-1] === definedOpenBraces[index]) {
                braces.pop();
                stage--;
                console.log(stage, braces);
                break;
            } else{
                console.log(braces, "not bananced");
                return;
            }
        }
    }
    isBalanced(s.substr(firstOccurance + 1), braces);
}
isBalanced(s, braces);
console.log("string is ", braces.length ? "un-Balanced" : "balanced");