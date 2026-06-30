public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> resList = new List<List<int>>();
        for(int i=0;i<nums.Length;i++)
        {
            for(int j=i+1;j<nums.Length;j++)
            {
                for(int k=j+1;k<nums.Length;k++)
                {
                    if(nums[i]+nums[j]+nums[k]==0)
                    {
                        bool isDuplicate = false;
                        List<int>triplet = new List<int>{nums[i],nums[j],nums[k]};
                        triplet.Sort();
                        foreach(var existing in resList)
                        {
                            if(existing[0] == triplet[0]
                            && existing[1]== triplet[1]
                            && existing[2] == triplet[2])
                            {
                                isDuplicate = true;
                                break;
                            }
                          
                        }
                         if(!isDuplicate)
                           {
                                resList.Add(triplet);
                           }
                                                   
                    }
                   
                }
            }
        }
        return resList;
    }
}
