public class Solution {
    public int MaxArea(int[] height) {
        int i=0;
        int j=height.Length-1;
        int maxArea=0;
        while(i<j)
        {
           int minHeight=Math.Min(height[i],height[j]);
           if((j-i)*minHeight>maxArea)
           {
                maxArea=(j-i)*minHeight;
           }
           
           if(height[i]>height[j])
            {
                j--;
            }
            else
            {
                i++;
            }
            
        }
        return maxArea;
    }
}