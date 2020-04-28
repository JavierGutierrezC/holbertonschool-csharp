using System;
using System.Collections.Generic;

    class List
    {
        public static int SafePrint(List<int> myList, int n)
        {
            
            int count = 0;
           try
            {
                for(int var = 0; var < n; var++)
                {
                    Console.WriteLine(myList[var]);
                    count++;
                }
                return(count);
            }
            catch
            {
                return(count);
            }
        }
    }

