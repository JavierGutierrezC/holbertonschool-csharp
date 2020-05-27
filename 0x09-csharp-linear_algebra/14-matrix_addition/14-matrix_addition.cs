using System;

///<summary>Class VectorMath</summary>
    class MatrixMath
    {
        ///<summary>adds two matrices</summary>
        ///<return>returns the resulting matrix</return>
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(0) == 2 && matrix2.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(1) == 2)
            {
                double[,] ans= {
                    {0, 0},
                    {0, 0}
                };
                ans[0, 0] = matrix1[0, 0] + matrix2[0, 0];
                ans[0, 1] = matrix1[0, 1] + matrix2[0, 1];
                ans[1, 0] = matrix1[1, 0] + matrix2[1, 0];
                ans[1, 1] = matrix1[1, 1] + matrix2[0, 1];
                return (ans);
            }
            if (matrix1.GetLength(0) == 3 && matrix2.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(1) == 3)
            {
                double[,] ans= {
                    {0, 0, 0},
                    {0, 0, 0},
                    {0, 0, 0}
                };
                ans[0, 0] = matrix1[0, 0] + matrix2[0, 0];
                ans[0, 1] = matrix1[0, 1] + matrix2[0, 1];
                ans[0, 2] = matrix1[0, 2] + matrix2[0, 2];
        
                ans[1, 0] = matrix1[1, 0] + matrix2[1, 0];
                ans[1, 1] = matrix1[1, 1] + matrix2[1, 1];
                ans[1, 2] = matrix1[1, 2] + matrix2[1, 2];
                
                ans[2, 0] = matrix1[2, 0] + matrix2[2, 0];
                ans[2, 1] = matrix1[2, 1] + matrix2[2, 1];
                ans[2, 2] = matrix1[2, 2] + matrix2[2, 2];

                return (ans);       
            }
            else
            {
                double[,] none = {{-1}};
                return(none);
            }
        }
    }