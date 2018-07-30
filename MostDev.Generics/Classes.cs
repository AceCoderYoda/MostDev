#region ...   [Header]   ...

// Solution      ::    MostDev
// Filename      ::    MostDev.Generics.Classes.cs
// By            ::    Arjan Crielaard

#endregion

#region ...   [Usings]   ...

using System.Collections.Generic;

#endregion

namespace MostDev.Generics
{
    public class GenericList<T>
    {
        private Node head;

        public T this[int x]
        {
            get
            {
                var current = head;
                for (var i = 0; i < x; i++) current = current.Next;
                return current.Data;
            }
            set
            {
                var current = head;
                for (var i = 0; i < x; i++) current = current.Next;

                var node = new Node(value);
                node.Next = current;
                current.Next = node;
            }
        }

        public void AddNode(T x)
        {
            var node = new Node(x);
            node.Next = head;
            head = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var begin = head;

            while (begin != null)
            {
                yield return begin.Data;
                begin = begin.Next;
            }
        }

        private class Node
        {
            public Node(T s)
            {
                Data = s;
            }

            public T Data { get; }
            public Node Next { get; set; }
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Function { get; set; }

        public int Age { get; set; }

        public void SetAge(int value)
        {
            Age = value;
        }
    }
}