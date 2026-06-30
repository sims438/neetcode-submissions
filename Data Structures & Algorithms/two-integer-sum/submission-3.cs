public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map= new Dictionary<int,int>();
        //saving counterpart/difference in map 
        for(int i=0;i<nums.Length;i++)
        {
            map[target-nums[i]] = i; 
        }
        //finding the difference,counterpart in same map
        for(int i =0 ; i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]) && map[nums[i]]!=i)
            {
                return new int[] {i,map[nums[i]]}; 
            }
        }
         return new int[] { };

    }
}
