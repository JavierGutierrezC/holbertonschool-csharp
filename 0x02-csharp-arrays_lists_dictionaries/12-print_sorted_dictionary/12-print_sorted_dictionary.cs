﻿using System;
using System.Collections.Generic;
using System.Linq;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
            foreach (KeyValuePair<string, string> elem in myDict.OrderBy(key => key.Key))
            {
                Console.WriteLine("{0}: {1}", elem.Key, elem.Value);
            }
        }
    }
