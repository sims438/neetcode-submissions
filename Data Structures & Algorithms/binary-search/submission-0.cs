public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length == 1)
        {
            return nums[0]==target?0:-1;
        }
        int l=0;
        int h=nums.Length-1;
        
        while(l<=h)
        {
            int mid=(l+h)/2;
            if(nums[mid]==target)
            {
                return mid;
            }
            else if(nums[mid]<target)
            {
                l=mid+1;
            }
            else
            {
                h=mid-1;
            }
        }
        return -1;
    }
}
