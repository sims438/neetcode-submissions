public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n =nums.Length;
        int[] soln = new int[n*2];
        for(int i = 0; i < n; i++)
        {
            soln[i]=nums[i];
            soln[i+n] = nums[i]; 
        }
        return soln;

    }
}