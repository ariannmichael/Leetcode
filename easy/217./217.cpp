#include <iostream>
#include <unordered_map>
class Solution {
public:
 bool containsDuplicate(vector<int>& nums) {
  unordered_map <int, int> hashmap;
  for(int i = 0; i < nums.size(); i++) {
   if(hashmap.find(nums[i]) != hashmap.end()) {
    return true;
   }
   
   hashmap.insert({nums[i], i});
  }
  return false;
 }
};