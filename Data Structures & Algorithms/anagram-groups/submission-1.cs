public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        foreach(string s in strs)
        {
          string sorted = new string(s.OrderBy(c=>c).ToArray());
          if(!dict.ContainsKey(sorted))
          {
            dict[sorted]=new List <String>();
          }
          dict[sorted].Add(s);
        }
        return new List<List<string>>(dict.Values);

    }
}
