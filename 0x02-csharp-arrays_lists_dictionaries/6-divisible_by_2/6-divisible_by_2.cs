using System;
using System.Collections.Generic;

    class List
    {
        public static List<bool> DivisibleBy2(List<int> myList)
        {
            List<bool> byTwo = new List<bool>();
            for (int x = 0; x < myList.Count; x++)
            {
                if (myList[x] % 2 == 0)
                {
                    byTwo.Add(true);
                }
                else
                {
                    byTwo.Add(false);
                }
            //return(byTwo);
            }
            return(byTwo);
        }
    }
