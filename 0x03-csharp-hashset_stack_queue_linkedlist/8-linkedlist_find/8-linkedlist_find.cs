using System;
using System.Collections.Generic;

    class LList
    {
        public static int FindNode(LinkedList<int> myLList, int value)
        {
            int ind = 0;
            foreach(int item in myLList)
            {
                if(item == value)
                {
                    return(ind);
                }
                ind++;
            } 
            return(-1);
        }
    }