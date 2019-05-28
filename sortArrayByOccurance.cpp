#include <iostream>
#include <map>
#include <set>
#include <vector>
using namespace std;

struct pairValues {
	int key;
	int value;
};

vector<int> sortArray(vector<int>& arr);
int main()
{
	vector<int> arr = { 1,2,3,4,2,3,4,7,6,8,1,3,9,6,7,6 };
	vector<int> sorted = sortArray(arr);
}

struct compairPairs {
	bool operator()(const pairValues& lhs, const pairValues& rhs)
	{
		if (lhs.value != rhs.value) {
			return lhs.value > rhs.value;
		}
		else {
			return lhs.key < rhs.key;
		}
	}
};

vector<int> sortArray(vector<int>& arr)
{

	map<int, int> mappedArray;
	set<pairValues, compairPairs> setOfValues;
	vector<int>::iterator itr = arr.begin();
	while (itr != arr.end()) {
		mappedArray[*itr]++;
		itr++;
	}
	vector<int> result;
	map<int, int>::iterator itr2 = mappedArray.begin();
	while (itr2 != mappedArray.end()) {
		pairValues a;
		a.key = itr2->first;
		a.value = itr2->second;
		setOfValues.insert(a);
		itr2++;
	}
	set<pairValues, compairPairs>::iterator itr3 = setOfValues.begin();
	while (itr3 != setOfValues.end())
	{
		pairValues value = *itr3;
		for (int i = 0; i < value.value; i++) {
			result.push_back(value.key);
		}
		itr3++;
	}
	int a = 1;
	return result;
}