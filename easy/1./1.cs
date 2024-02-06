public class Solution
{
 public int[] TwoSum(int[] nums, int target)
 {
  Dictionary<int, int> diffDic = new Dictionary<int, int>();
  int[] result = new int[2];

  for (int i = 0; i < nums.Length; i++)
  {
   int subt = target - nums[i];

   if (diffDic.ContainsKey(subt))
   {
    result[1] = i;
    result[0] = diffDic[subt];
    return result;
   }
   else
   {
    diffDic.TryAdd(nums[i], i);
   }

  }

  return result;
 }
}