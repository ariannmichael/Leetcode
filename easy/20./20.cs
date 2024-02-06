public class Solution
{
 public bool IsValid(string s)
 {
  Stack<char> stack = new Stack<char>();

  foreach (char c in s)
  {
   char r;
   switch (c)
   {
    case ')':
     stack.TryPop(out r);
     if (r != '(') return false;
     continue;
    case ']':
     stack.TryPop(out r);
     if (r != '[') return false;
     continue;
    case '}':
     stack.TryPop(out r);
     if (r != '{') return false;
     continue;
    default:
     stack.Push(c);
     continue;
   }
  }

  return stack.ToList().Count == 0;
 }
}