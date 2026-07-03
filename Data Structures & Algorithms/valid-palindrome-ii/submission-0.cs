public class Solution {
    public bool ValidPalindrome(string s) {
        int i=0;
        int j=s.Length-1;
        bool res=true;
        while(i<j)
        {
            if(s[i]!=s[j])
            {
                return (isValid(s,i+1,j)||isValid(s,i,j-1));
            }
            else
            {
                i++;
                j--;
            }
        }
        return res;
    }
    public bool isValid(string s,int i,int j)
    {
        while(i<j)
        {
            if(s[i]!=s[j])
            {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }
}