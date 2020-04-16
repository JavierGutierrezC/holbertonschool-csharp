using System;
using System.Collections.Generic;

    class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if (myList.Count == 0)
            {
                Console.WriteLine("List is empty");
                return(-1);
            }
            else
            {
                myList.Sort();
                //Console.WriteLine(myList[myList.Count -1]);
                return(myList[myList.Count -1]);
            }
        }
    }
