using System;
using System.Collections.Generic;


    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            LinkedList<int> newLlist = new LinkedList<int>();
            
            if(size < 0)
            {
                return(newLlist);
            } 
            else{
                for(int x = 0; x < size; x++)
                    {
                    Console.WriteLine(x);
                    newLlist.AddLast(x);
                    }
                return(newLlist);
            }
        }
    }

