public class Solution {
    public void SortColors(int[] nums) {
        int i=0;
        int j=nums.Length-1;
        int mid = 0;
        while(mid<=j)
        {
            if(nums[mid]==0)
            {
                Swap(nums,i,mid);
                i++;
                mid++;
            }
            else if(nums[mid]==2)
            {
                Swap(nums,mid,j);
                j--;
            }
            else
            {
                mid++;
            }
        }
        
    }
    public void Swap(int [] nums,int left,int right)
    {
        int temp = nums[left];
        nums[left]=nums[right];
        nums[right]=temp;
    }
}