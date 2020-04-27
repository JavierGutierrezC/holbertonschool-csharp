using System;
using System.Collections.Generic;

    class LList
    {
        public static int GetNode(LinkedList<int> myLList, int n)
        {
            int ind = 0;
            foreach(int item in myLList)
            {
                if(ind == n)
                {
                    return(item);
                }
                ind++;
            } 
            return(0);
        }
    }

