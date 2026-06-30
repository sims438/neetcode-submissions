public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string lcp = "";
        string s = strs[0];
        if(strs.Length == 1)
        {
            return strs[0];
        }
        
        for(int i=0;i<s.Length;i++)
        { 
            for(int j = 1;j<strs.Length;j++)
            {
                string temp = strs[j];
                if(i>=temp.Length || s[i]!=temp[i])
                    return lcp;                 
            }
            lcp+=(s[i]);   
        }
        return lcp;
    }
}