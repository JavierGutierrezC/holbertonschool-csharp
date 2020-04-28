using System;
using System.Collections.Generic;

    class LList
    {
        public static void Delete(LinkedList<int> myLList, int index)
        {
            
            LinkedListNode<int> act = myLList.First;
          
            if(act == null || myLList.Count <= index || index < 0)
            {
                return;
            }
            else
            {
                for(int x = 0; x < index; x++) 
                {
                    //Console.WriteLine("indice {0}", x); 
                    //Console.WriteLine("indice.val1 {0}", act.Value);  
                    act = act.Next;
                    //Console.WriteLine("indice.val2 {0}", act.Value);
                }
            }
            myLList.Remove(act);
            
        }
    }
