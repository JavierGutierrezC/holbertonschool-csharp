using System;


    class Array
    {
        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0)
            { 
                Console.WriteLine();
            }
            else
            {
                int arrayLength = array.Length -1;
                string space = " ";
                for (int x = arrayLength; x >= 0; x--)
                { 
                    Console.Write(array[x]);
                    Console.Write(space);
                }
            }
        }
    }
