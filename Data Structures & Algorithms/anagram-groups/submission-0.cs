public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res = new List<List<string>>();
        Dictionary<String,int> dict = new Dictionary<String,int>();
        foreach(string s in strs)
        {
          string sorted = new string(s.OrderBy(c => c).ToArray());
          if(!dict.ContainsKey(sorted))
          {
            List<string> temp = new List<String>();
            temp.Add(s);
            res.Add(temp);
            dict.Add(sorted,res.Count-1);
          }
          else
          {
            int index = dict[sorted];
            res[index].Add(s);
          }

        }
        return res;
        
    }
}
