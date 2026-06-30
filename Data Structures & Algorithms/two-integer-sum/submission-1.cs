public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         Dictionary<int, int> map = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++) {
        map[target - nums[i]] = i;  // Store the complement and current index
    }
    
    // Second pass: look for current value in hashmap
    for (int i = 0; i < nums.Length; i++) {
        if (map.ContainsKey(nums[i]) && map[nums[i]] != i) {
            return new int[] { i, map[nums[i]] };
        }
    }
    
    return new int[] { };
    }
}
