using System;
using System.Collections.Generic;
using System.Linq;
    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            string name = "0";
            foreach (KeyValuePair<string, int> elem in myList.OrderByDescending(key => key.Value))
            {
                //Console.WriteLine("{0}: {1}", elem.Key, elem.Value);
                name = elem.Key;
                return(name);
            }
            return(name);
        }
    }
