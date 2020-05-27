using System;

///<summary>Class VectorMath</summary>
    class MatrixMath
    {
        ///<summary>multiplies a matrix and a scalar</summary>
        ///<return>returns the resulting matrix</return>
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
            if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2 )
            {
                double[,] ans= {
                    {0, 0},
                    {0, 0}
                };
                ans[0, 0] = matrix[0, 0] * scalar;
                ans[0, 1] = matrix[0, 1] * scalar;
                ans[1, 0] = matrix[1, 0] * scalar;
                ans[1, 1] = matrix[1, 1] * scalar;
                return (ans);
            }
            if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
            {
                double[,] ans= {
                    {0, 0, 0},
                    {0, 0, 0},
                    {0, 0, 0}
                };
                ans[0, 0] = matrix[0, 0] * scalar;
                ans[0, 1] = matrix[0, 1] * scalar;
                ans[0, 2] = matrix[0, 2] * scalar;
        
                ans[1, 0] = matrix[1, 0] * scalar;
                ans[1, 1] = matrix[1, 1] * scalar;
                ans[1, 2] = matrix[1, 2] * scalar;
                
                ans[2, 0] = matrix[2, 0] * scalar;
                ans[2, 1] = matrix[2, 1] * scalar;
                ans[2, 2] = matrix[2, 2] * scalar;

                return (ans);       
            }
            else
            {
                return new double[,] { { -1 } };
            }
        }
    }
