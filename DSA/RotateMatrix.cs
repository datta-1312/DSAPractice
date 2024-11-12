public class RotateMatrix
{
    public void Rotate(int[][] matrix) 
    {  
        for(int row = 0; row < matrix[0].Length; row++)
        {
            for(int col = row; col < matrix[0].Length; col++)
            {
                (matrix[row][col],matrix[col][row]) = (matrix[col][row],matrix[row][col]);
            }
        }
        int half = matrix[0].Length/2;
        for(int row = 0; row < matrix[1].Length; row++)
        {
            for(int left = half-1,right=half+1; right < matrix[1].Length; left--,right++)
            {
                (matrix[row][left],matrix[row][right]) = (matrix[row][right],matrix[row][left]);
            }
        }
    }
}