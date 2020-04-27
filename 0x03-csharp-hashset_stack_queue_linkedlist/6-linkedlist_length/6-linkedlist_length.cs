using System;
using System.Collections.Generic;

    class LList
    {
        public static int Length(LinkedList<int> myLList)
        {
            int Cont = 0;
            foreach(int item in myLList)
                Cont++;

            return(Cont);
        }
    }
