public class Solution {
    public int MySqrt(int x) {
        if(x==0)
            return 0;
        int h = x/2;
        if(x<=3)
            return 1;
        int l=1;
        while(l<=h)
        {
            int mid=l+(h-l)/2;
            long temp = (long)mid*mid;
            if(temp == x)
                return mid;
            else if(temp > x)
            {
                h=mid-1;
            }
            else
            {
                l=mid+1;
            }
        }
        return h;

        
    }
}