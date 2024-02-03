class Solution {
 public boolean containsDuplicate(int[] nums) {
  Set<Integer> count = new HashSet<Integer>();

  for(Integer n : nums) {
   if(count.contains(n)) {
    return true;
   }
   count.add(n);
  }

  return false;
 }
}