public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l=0;
        int r=matrix.Length-1;
        while(l<=r)
        {
            int mid = l + (r - l) / 2;
            if(matrix[mid][0]==target)
                return true;
            else if(matrix[mid][0]>target)
            {
                r=mid-1;
            }
            else
            {
                l=mid+1;
            }

        }
        int rowIndex=l-1;
        if (rowIndex<0)
            return false;
        int i=0;
        int j=matrix[rowIndex].Length-1;
        while(i<=j)
        {
            int mid = (i+j)/2;
            if(matrix[rowIndex][mid]==target)
                return true;
            else if(matrix[rowIndex][mid]>target)
            {
                j=mid-1;
            }
            else
            {
                i=mid+1;
            }
        }
        return false;

    }
}
