using System;

    ///<summary>Obj class</summary>
    class Obj
    {
        /// <summary> method that returns True 
        ///if the object is an instance of, or if the object is an instance of 
        ///a class that inherited from, Array</summary>
        public static bool IsInstanceOfArray(object obj)
        {
            if(obj is Array)
            {
                return(true);
            }
            else
            {
                return(false);
            }
        }
    }
