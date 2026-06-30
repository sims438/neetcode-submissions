public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int l1=word1.Length;
        int l2=word2.Length;
        int i=0;
        int j=0;
        string res="";

        while(i<l1 && j<l2)
        {
            res+=word1[i++];
            res+=word2[j++];
        }
        res+=l1>l2?word1.Substring(i):word2.Substring(j);
        return res;
    }
}