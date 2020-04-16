using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if(size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return(null);
            }
            else
            {
                List<int> myList = new List<int>();
                for (int x = 0; x < size; x++)
                {
                    myList.Add(x);
                    //Console.Write(myList[x]);
                    
                }
            Console.WriteLine(string.Join(" ", myList));
            return(myList);
            }
        }
    }

