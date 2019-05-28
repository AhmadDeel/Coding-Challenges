#include <iostream>
#include <map>
#include <vector>
using namespace std;

string removeDouplicates(string& s);
string removeDouplicatesVector(string& s);

int main()
{
	string s = "Ahmad Jalali Deel";
	cout << removeDouplicates(s) << endl;
	cout << removeDouplicatesVector(s) << endl;
}

string removeDouplicates(string& s)
{
	// Don't know why map has a sorting function
	// 's' is before 'd' but would come after d
	map<char, int> douplicates;
	for (int i = 0; i < s.length(); i++) {
		douplicates[s[i]]++;
	}
	map<char, int>::iterator itr = douplicates.begin();
	string result;
	while (itr != douplicates.end())
	{
		result += itr->first;
		itr++;
	}
	return result;
}
string removeDouplicatesVector(string& s)
{
	vector<char> douplicates;
	for (int i = 0; i < s.length(); i++) {
		bool vectorContains = find(douplicates.begin(), douplicates.end(), s[i]) != douplicates.end();
		if (!vectorContains)
			douplicates.push_back(s[i]);
	}
	string result;
	vector<char>::iterator itr = douplicates.begin();
	while (itr!=douplicates.end())
	{
		result += *itr;
		itr++;
	}
	return result;
}