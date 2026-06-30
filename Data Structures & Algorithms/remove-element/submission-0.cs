public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int i=0;
        int j=(nums.Length)-1;
        int c=0;
        while(i<j)
        {
            if(nums[i]!=val)
            {
                i++;
                continue;
            }
            if(nums[j]==val)
            {
                j--;
                continue;
            }
            if(nums[i]==val)
            {
                int temp = nums[i];
                nums[i]=nums[j];
                nums[j]=temp;
                i++;
                j--;
                continue;
            }
        }
        foreach(int n in nums)
        {
            if(n==val)
                c++;
        }
        return (nums.Length-c);
        
    }
}