public class Solution
{
 public int Search(int[] nums, int target)
 {
  int left = 0;
  int right = nums.Length;
  int m = 0;

  while (left < right)
  {
   m = left + (right - left) / 2;
   if (nums[m] == target)
   {
    return m;
   }
   else if (nums[m] > target)
   {
    right = m;
   }
   else if (nums[m] < target)
   {
    left = m + 1;
   }
  }

  return -1;
 }
}