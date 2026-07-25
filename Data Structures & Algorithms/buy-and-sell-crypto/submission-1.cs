public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0;
        int r=1;
        int max = -1;
        while(r<prices.Length)
        {
            if(prices[r]<prices[l])
            {
                l=r;
            }
            else if(prices[r]>prices[l])
            {
                if(prices[r]-prices[l]> max){

                    max=prices[r]-prices[l];
                }
            }
            r++;
        }
        return max<0?0:max;
    }
}
















































