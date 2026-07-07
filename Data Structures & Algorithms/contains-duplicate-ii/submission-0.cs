public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> Dict = new Dictionary<int,int>();
        int i=0;
        while(i<nums.Length)
        {
            if(Dict.ContainsKey(nums[i]))
            {
                if(i-Dict[nums[i]]<=k)
                {
                    return true;
                }
                else
                {
                    Dict[nums[i]]=i;
                    i++;
                }
            }
            else
            {
                 Dict.Add(nums[i],i);
                i++;
            }
           
        }
        return false;
    }
}