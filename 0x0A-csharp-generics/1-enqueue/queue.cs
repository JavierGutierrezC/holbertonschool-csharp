using System;

/// <summary>Queue Generic class </summary>
    class Queue<T>
    {
        /// <summary>Linked list creator</summary>
        public class Node 
        {
            public T value;
            public Node next = null;

            public Node(T value)
            {
                this.value = value;
            }
        }
        
        public Node head;
        public Node tail;
        public int count;

        /// <summary>Adds a node</summary>
        public void Enqueue(T value) 
        {
            Node node = new Node(value);
            if (head == null)
            {
                head = node;
            }
            if (tail != null)
            {
                tail.next = node;
            }
            tail = node;
            count ++;
        }
        /// <summary>returns count</summary>
        // <return> returns number of nodes</return>
        public int Count()
        {
            return count;
        }

        /// <summary>returns type of the object</summary>
        // <return> returns type of the object</return>
        public Type CheckType()
        {
            return typeof(T); 
        }
    }
