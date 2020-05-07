using System;

    ///<summary>Obj class</summary>
    class Obj
    {
        /// <summary>method that returns True if the object is an int</summary>
        public static bool IsOfTypeInt(object obj)
        {
            if(obj is int)
            {
                return(true);
            }
            else
            {
                return(false);
            }
        }
    }
