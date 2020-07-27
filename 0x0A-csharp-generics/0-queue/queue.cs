using System;

/// <summary>Queue Generic class </summary>
    class Queue<T>
    {
        /// <summary>returns type of the object</summary>
        // <return> returns type of the object</return>
        public Type CheckType()
        {
            return typeof(T); 
        }
    }