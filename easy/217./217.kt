class Solution {
 fun containsDuplicate(nums: IntArray): Boolean {
  val count = hashSetOf<Int>();

  for(n in nums) {
   if(count.contains(n)) {
    return true;
   }

   count.add(n);
  }

  return false;
 }
}