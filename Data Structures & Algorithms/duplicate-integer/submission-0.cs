public class Solution {
    public bool hasDuplicate(int[] nums) {
        int c=0;
        foreach(int i in nums)
        {
            foreach(int j in nums)
            {
                if(j==i)
                {
                    c+=1;
                    if(c>1)
                    {
                        return true;
                    }
                }
            }
            c=0;
        }
        return false;
    }
}