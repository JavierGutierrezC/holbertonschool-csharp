using System;


    class Program
    {
        static void Main(string[] args)
        {
            int[][] ja_Arr = new int[][]
            {
                new int[] {0, 1, 2, 3},
                new int[] {0, 1, 2, 3, 4, 5, 6},
                new int[] {0, 1}
            };
            for (int x = 0; x < ja_Arr.Length; x++) 
            {
                for (int y = 0; y < ja_Arr[x].Length; y++) 
                {
                    Console.Write(ja_Arr[x][y]);
                    if(y !=ja_Arr[x].Length -1)
                    {
                        Console.Write(" ");
                    }
                }
            Console.WriteLine();
            }
            
        }
    }
