using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
        {
            Dictionary<string, int> newDict = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> elem1 in myDict)
            {
                newDict.Add(elem1.Key, elem1.Value * 2);
                //Console.WriteLine(newDict);
            }
            //return(myDict);
            return(newDict);
        }
    }

