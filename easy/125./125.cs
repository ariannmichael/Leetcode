using System.Text.RegularExpressions;

public class Solution
{
 public bool IsPalindrome(string s)
 {
  var plainS = s.Where(i => Char.IsLetterOrDigit(i)).Select(i => Char.ToLower(i)).ToList();
  int p1 = 0;
  int p2 = plainS.Count - 1;

  while (p1 <= p2)
  {
   if (plainS[p1] != plainS[p2])
   {
    return false;
   }
   p1++;
   p2--;
  }

  return true;
 }
}