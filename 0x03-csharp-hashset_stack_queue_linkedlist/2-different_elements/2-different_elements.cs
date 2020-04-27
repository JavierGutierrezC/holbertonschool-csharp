using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            List<int> sorted1 = list1.FindAll(num => !list2.Contains(num));
            //foreach(int nu in sorted1)
            //Console.Write($"{nu}");
            List<int> sorted2 = list2.FindAll(num => !list1.Contains(num));
            //foreach(int ni in sorted2)
            //Console.Write($"{ni}");
            sorted1.AddRange(sorted2);
            //foreach(int ni in sorted1)
            //Console.Write($"{ni}");
            sorted1.Sort();
        return(sorted1);
        }
        
    }

