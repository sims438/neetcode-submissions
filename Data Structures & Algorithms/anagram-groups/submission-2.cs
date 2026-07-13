public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string,List<string>>();
        foreach(string s in strs)
        {
          string temp = new string(s.OrderBy(c=>c).ToArray());
          //add to dict if not availible
          if(!dict.ContainsKey(temp))
          {
            dict[temp] = new List<String>();
          }
          dict[temp].Add(s);
        }
        return new List<List<string>>(dict.Values);
    }
}
