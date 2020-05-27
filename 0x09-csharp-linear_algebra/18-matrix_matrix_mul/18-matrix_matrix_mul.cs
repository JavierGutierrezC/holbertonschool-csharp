using System;

/// <summary>Class operations with matrices</summary>
class MatrixMath
{
    /// <summary>Method that multiplies two matrices</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) == matrix2.GetLength(0))
        {
            int row = matrix1.GetLength(0);
            int col_m1 = matrix1.GetLength(1);
            int col_m2 = matrix2.GetLength(1);
            double[,] newMatrix = new double[row, col_m2];

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col_m2; y++)
                {
                    double value= 0; 
                    for (int z = 0; z < col_m1; z++)
                    {
                        value= value+ matrix1[x, z] * matrix2[z, y];
                    }
                    newMatrix[x, y] = value;
                }
            }
            return newMatrix;
        }
        return new double[,] {{ -1 }};   
    }
}