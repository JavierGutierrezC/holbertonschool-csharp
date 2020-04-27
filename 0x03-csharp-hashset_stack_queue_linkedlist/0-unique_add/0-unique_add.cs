using System;
using System.Collections.Generic;


    class List
    {
        public static int Sum(List<int> myList)
        {
            HashSet<int> myHash = new HashSet<int>(myList);
            int count = 0;

            foreach(int item in myHash)
            {
                count += item;
            }
            return(count);
        }
    }
