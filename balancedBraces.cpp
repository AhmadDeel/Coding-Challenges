#include <iostream>
#include <stack>
using namespace std;

const string definedOpenBraces = "{[(<";
const string definedloseBraces = "}])>";
enum braceType { open, none, close };
void isBalanced(string s, stack<char>& braces);

int main()
{
	string s = "[()]<>{}()";
	stack<char> braces;
	isBalanced(s, braces);
	string result = braces.size() == 0 ? "\tYes, string is balanced" : "\tNo, string is un-balanced";
	cout << result << endl;
}

braceType stringContainsBraces(char ch)
{
	braceType result = none;
	for (int i = 0; i < definedOpenBraces.size(); i++) {
		if (ch == definedOpenBraces[i])
			result = open;
		if (ch == definedloseBraces[i])
			result = close;
	}
	return result;
}
void isBalanced(string s, stack<char> & braces)
{
	if (s.length() == 0)
		return;
	int firstOccurance = 0;
	for (int i = 0; i < s.length(); i++) {
		if (stringContainsBraces(s[i]) == open) {
			firstOccurance = i;
			braces.push(s[i]);
			cout << '\t' << s[i] << endl;
			break;
		}
		else if (stringContainsBraces(s[i]) == close) {
			int index = definedloseBraces.find(s[i]);
			if (braces.top() == definedOpenBraces[index]) {
				braces.pop();
				cout << '\t' << s[i] << endl;
				break;
			}
			else {
				cout << "\terror:\t" << braces.top() << " != " << s[i] << endl;
				return;
			}
		}
	}
	isBalanced(s.substr(firstOccurance + 1), braces);
}