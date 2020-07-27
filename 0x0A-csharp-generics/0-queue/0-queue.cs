using System;

/// <summary>Queue<T> Generic class </summary>
    class Queue<T>
    {
        /// <summary>returns type of the object</summary>
        public Type CheckType()
        {
            return typeof(T); 
        }
    }
