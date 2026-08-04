public class Solution {
    public void SortColors(int[] nums) {
        int i=0;
        int j=nums.Length-1;
        int mid=0;
        while(mid<=j)
        {
            if(nums[mid]==1)
                mid++;
            else if(nums[mid]==0)
            {
                Swap(nums,i,mid);
                i++;
                mid++;
            }
            else
            {
                Swap(nums,j,mid);
                //bcs our swap could be either 0 or 1
                j--;
            }
        }
    }
    public void Swap(int []nums,int left,int right)
    {
        int temp=nums[left];
        nums[left]=nums[right];
        nums[right]=temp;
    }
}