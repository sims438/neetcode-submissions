public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<List<int>> res = new List<List<int>>();
        for(int i=0;i<nums.Length-2;i++)
        {
            int j=i+1;
            int k=nums.Length-1;
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            while(j<k)
            {
                int sum = nums[i]+nums[j]+nums[k];
               if(sum==0)
               {
                while(j<k && nums[j]==nums[j+1])j++;
                while(k>j && nums[k]==nums[k-1])k--;                
                List<int> temp = new List<int> { nums[i], nums[j], nums[k]};
                res.Add(temp);               
                j++;
                k--;
               }
               else if(nums[i]+nums[j]+nums[k]<0)
               {
                j++;
               }
               else
               {
                k--;
               }
            }
        }
        return res;
    } 
}
