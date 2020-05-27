using System;

///<summary>Class VectorMath</summary>
    class MatrixMath
    {
        ///<summary>adds two matrices</summary>
        ///<return>returns the resulting matrix</return>
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
            if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && 
            matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
            {
                double[,] ans= {
                    {0, 0},
                    {0, 0}
                };
                ans[0, 0] = matrix1[0, 0] * scalar;
                ans[0, 1] = matrix1[0, 1] * scalar;
                ans[1, 0] = matrix1[1, 0] * scalar;
                ans[1, 1] = matrix1[1, 1] * scalar;
                return (ans);
            }
            if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && 
            matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
            {
                double[,] ans= {
                    {0, 0, 0},
                    {0, 0, 0},
                    {0, 0, 0}
                };
                ans[0, 0] = matrix1[0, 0] * scalar;
                ans[0, 1] = matrix1[0, 1] * scalar;
                ans[0, 2] = matrix1[0, 2] * scalar;
        
                ans[1, 0] = matrix1[1, 0] * scalar;
                ans[1, 1] = matrix1[1, 1] * scalar;
                ans[1, 2] = matrix1[1, 2] * scalar;
                
                ans[2, 0] = matrix1[2, 0] * scalar;
                ans[2, 1] = matrix1[2, 1] * scalar;
                ans[2, 2] = matrix1[2, 2] * scalar;

                return (ans);       
            }
            else
            {
                return new double[,] { { -1 } };
            }
        }
    }
