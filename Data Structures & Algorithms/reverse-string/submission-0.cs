public class Solution {
    public void ReverseString(char[] s) {
        int i=0;
        int j=s.Length-1;
        while(i<j)
        {
            if(s[i]==s[j])
            {
                i++;
                j--;
                continue;
            }
            char temp =s[i];
            s[i]=s[j];
            s[j]=temp;
            i++;
            j--;
        }
    }
}