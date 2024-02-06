public class Solution
{
  public int FindMin(int[] nums)
  {
    int cur = nums[0];
    int l = 0;
    int r = nums.Length - 1;
    int m = 0;

    while (l <= r)
    {
      if (nums[l] < nums[r])
      {
        cur = Math.Min(cur, nums[l]);
      }

      m = (l + r) / 2;
      cur = Math.Min(cur, nums[m]);

      if (nums[m] >= nums[l])
      {
        l = m + 1;
      }
      else
      {
        r = m - 1;
      }
    }

    return cur;
  }
}