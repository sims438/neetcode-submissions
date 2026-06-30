public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> count = new Dictionary<char, int>(); 
if (s.Length != t.Length) return false;
        foreach (char c in s) {
    if (count.ContainsKey(c)) {
        count[c]++;  // Increment existing value by 1
    } else {
        count[c] = 1;  // Start with 1
    }
}
        foreach(char c2 in  t)
        {
            if (!count.ContainsKey(c2)) return false;
            count[c2]--;
            if (count[c2] < 0) return false;
        }
        return true ;

    }
}
