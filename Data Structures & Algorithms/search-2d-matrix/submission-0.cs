public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int col=matrix[0].Length;
        int tot=rows*col;
        for(int i=0;i<rows;i++)
        {
            for(int j=0;j<col;j++)
            {
                if(matrix[i][j]==target)
                    return true;
            }
        }
        return false;

    }
}
