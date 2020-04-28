using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
        {
            List<int> divList = new List<int>();
            for (int x = 0; x < listLength; x++)
            try
            {
                //for (int x = 0; x < listLength; x++)
                {
                    int div = list1[x] / list2[x];
                    divList.Add(div);
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                divList.Add(0);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            return(divList);
        }
    }
