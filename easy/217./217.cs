public class Solution
{
  public bool ContainsDuplicate(int[] nums)
  {
    Dictionary<int, int> countNumber = new Dictionary<int, int>();

    foreach (int num in nums)
    {
      if (countNumber.ContainsKey(num))
      {
        countNumber[num] += 1;
      }
      else
      {
        countNumber.Add(num, 1);
      }
    }

    foreach (KeyValuePair<int, int> entry in countNumber)
    {
      if (entry.Value > 1)
      {
        return true;
      }
    }

    return false;
  }
}