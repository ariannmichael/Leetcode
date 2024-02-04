public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }

        Dictionary<char, int> mapStringS = new Dictionary<char, int>();
        Dictionary<char, int> mapStringT = new Dictionary<char, int>();

        foreach(char c in s) {
            if(mapStringS.ContainsKey(c)) {
                mapStringS[c] += 1;
            } else {
                mapStringS.Add(c, 1);
            }
        }

        foreach(char c in t) {
            if(mapStringT.ContainsKey(c)) {
                mapStringT[c] += 1;
            } else {
                mapStringT.Add(c, 1);
            }
        }

        foreach(var entry in mapStringS.Keys) {
            if(!(mapStringT.TryGetValue(entry, out var value) && mapStringS[entry].Equals(value))) {
                return false;
            }
        }

        return true;
    }
}