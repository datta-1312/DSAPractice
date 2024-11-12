public class MatrixSearch
{
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.GetLength(0);
        int cols = matrix[0].Length;
    
        int top = 0, bottom = rows;
        int mid = 0;
        while(top < bottom)
        {
            mid = top+(bottom - top)/2;
            if(target == matrix[mid][0])
                return true;
            if(target < matrix[mid][0])
            {
                mid--;
                bottom = mid;
                continue;
            }
            mid++;
            top = mid;
        }
        
        for(int i = 0; i < cols; i++)
        { 
            if(matrix[mid][i] == target)
            {
                return true;
            }
        }
        return false;
    }
}
/*
int rows = matrix.GetLength(0);
        int cols = matrix[0].Length;
        int top = 0, bottom = rows-1, rowIndex = 0;
        while(top < bottom)
        {
            int mid = top+(bottom - top)/2;
            if(target < matrix[mid][0])
            {
                bottom = mid;
                continue;
            }
            top = mid+1;
        }
        rowIndex = target <= matrix[top][0] ? top : top - 1;
        for(int i = 0; i < cols; i++)
        { 
            if(matrix[rowIndex][i] == target)
            {
                return true;
            }
        }
        return false;
*/