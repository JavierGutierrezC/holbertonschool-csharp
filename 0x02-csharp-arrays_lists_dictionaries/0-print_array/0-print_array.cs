using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            { 
                Console.WriteLine("Size cannot be negative");
                return(null);
             }
            else
            {
                int[] myArray = new int[size];
                int x;
                for (x = 0; x < size; x++)
                {
                    myArray[x] = x; 
                    //Console.Write(" " + myArray[x]);
                }
                Console.WriteLine(string.Join(" ",myArray));
                return(myArray);

            }
        }
    }
