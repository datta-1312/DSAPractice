public class DiagonalSumOfMatrices {
    public int DiagonalSum(int[][] mat) {
        if(mat.GetLength(0) == 1) return mat[0][0];
        int diagonalSum = 0;
        int intersectingIndex = mat.GetLength(0)%2 != 0 ? mat.GetLength(0)/2 : 0;
       
        for(int i = 0, j = 0; i < mat.Length; i++,j--)
        {
            j = mat[i].Length-1 - i;
            if(intersectingIndex > 0)
            {
                if(i != intersectingIndex)
                {
                    diagonalSum += (mat[i][i]+mat[j][j]);
                    continue;
                }
                diagonalSum += mat[i][i];
                continue;
            }
            diagonalSum += (mat[i][i]+mat[j][j]);
        }
        return diagonalSum;
    }
}