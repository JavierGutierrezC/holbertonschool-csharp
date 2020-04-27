using System;
using System.Collections.Generic;

    class LList
    {
        public static int Sum(LinkedList<int> myLList)
        {
            int Cont = 0;
            foreach(int item in myLList)
                Cont += item;

            return(Cont);
        }
    }

