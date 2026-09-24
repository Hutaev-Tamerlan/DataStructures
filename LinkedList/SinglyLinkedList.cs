using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class SinglyLinkedList<T>
    {
        private Node<T> Head { get; set; } = null;

        private int _count = 0;
        public int Count { get { return _count;  } }

        public void Print()
        {
            Node<T> current = Head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = Head;
            Head = newNode;
            _count++;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                _count++;
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
            _count++;
        }

        public void AddRangeFirst(IEnumerable<T> items)
        {
            foreach (T item in items.Reverse())
            {
                AddFirst(item);
            }
        }

        public void AddRangeLast(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                AddLast(item);
            }
        }

        public void Remove(T data)
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Data.Equals(data))
            {
                Head = Head.Next;
                _count--;
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    _count--;
                    return;
                }

                current = current.Next;
            }
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }

            Head = Head.Next;
            _count--;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                return;
            }

            if (Head.Next == null)
            {
                Head = null;
                _count--;
                return;
            }

            Node<T> current = Head;

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
            _count--;
        }

        public void Clear()
        {
            Head = null;
            _count = 0;
        }
    }
}
