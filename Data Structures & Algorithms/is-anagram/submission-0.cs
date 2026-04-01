public class Solution {
    public bool IsAnagram(string s, string t) {

        if (s.Length != t.Length) return false;

        Dictionary<char, int> chars = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++) {
            if (chars.ContainsKey(s[i]))
            {
                chars[s[i]] += 1;
            }
            else {
                chars.Add(s[i], 1);
            }
        }

        for (int i = 0; i < t.Length; i++) {
            if (chars.ContainsKey(t[i]))
            {
                chars[t[i]] -= 1;
            }
            else {
                return false;
            }
        }
        
       foreach (var entry in chars)
       {
            if (entry.Value != 0) return false;
       }

       return true;
    }
}
