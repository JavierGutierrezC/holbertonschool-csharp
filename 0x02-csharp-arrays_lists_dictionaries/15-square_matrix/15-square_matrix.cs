using System;


    class Matrix
    {
        public static int[,] Square(int[,] myMatrix)
        {
            int[,] newM = new int[myMatrix.GetLength(0),myMatrix.GetLength(0)];
            for (int x = 0; x < myMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < myMatrix.GetLength(0); y++)
                {
                    newM[x,y] = (int)Math.Pow(myMatrix[x,y], 2);
                    //Console.Write(newM[x,y]);
                }
                
            } 
            return(newM);
        }
    }
