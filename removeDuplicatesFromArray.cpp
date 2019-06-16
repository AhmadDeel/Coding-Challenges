#include <iostream>
#include <vector>
using namespace std;

vector<int> removeDuplicates(vector<int>& v)
{
	vector<int> result;
	for (int i = 0; i < v.size(); i++) {
		bool found = false;
		for (int j = 0; j < v.size(); j++) {
			if (j != i && v[j] == v[i]) {
				found = true;
				break;
			}
		}
		if (!found) {
			result.push_back(v[i]);
		}
	}
	return	 result;
}
void printVector(vector<int>& v, string name)
{
	int i = 0;
	cout << "removing duplicates from " << name << endl;
	while (i < v.size()) {
		cout << "values:\t" << v[i] << endl;
		i++;
	}
}
int main()
{
	vector<int> test1 = { 1,9,8,2,7,3,2,3,1 };
	vector<int> test2 = { 1,2,3,4,5,6 };
	vector<int> test3 = { 1,2,4,2,4,1 };

	vector<int> result1 = removeDuplicates(test1);
	vector<int> result2 = removeDuplicates(test2);
	vector<int> result3 = removeDuplicates(test3);
	printVector(result1, "test1");
	printVector(result2, "test2");
	printVector(result3, "test3");
}