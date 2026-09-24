using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class CircularDoublyLinkedList<T>
    {
        private Node<T> Head { get; set; } = null;


        private int _count = 0;

        public int Count { get { return _count; } }

        public void Print()
        {
            if (Head == null)
            {
                return;
            }

            Node<T> current = Head;

            do
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            while(current != Head);

            Console.WriteLine();
        }

        public void PrintReverse()
        {
            if (Head == null)
            {
                return;
            }

            Node<T> current = Head.Previous;

            do
            {
                Console.Write(current.Data + " ");
                current = current.Previous;
            }
            while (current != Head.Previous);

            Console.WriteLine();
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
                Head.Previous = Head;
            }
            else
            {
                newNode.Next = Head;
                newNode.Previous = Head.Previous;

                Head.Previous.Next = newNode;
                Head.Previous = newNode;

                Head = newNode;
            }
            
            _count++;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                Head.Next = Head;
                Head.Previous = Head;
            }
            else
            {
                newNode.Next = Head;
                newNode.Previous = Head.Previous;

                Head.Previous.Next = newNode;
                Head.Previous = newNode;
            }

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

            Node<T> current = Head;

            do
            {
                if (current.Data.Equals(data))
                {
                    if (_count == 1)
                    {
                        Clear();
                        return;
                    }

                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;

                    if (current == Head)
                    {
                        Head = current.Next;
                    }

                    _count--;
                    return;
                }
                current = current.Next;
            }
            while (current != Head);
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }

            if (_count == 1)
            {
                Clear();
                return;
            }

            Head.Previous.Next = Head.Next;
            Head.Next.Previous = Head.Previous;
            Head = Head.Next;

            _count--;
        }

        public void RemoveLast()
        {
            if (Head == null)
            {
                return;
            }

            if (_count == 1)
            {
                Clear();
                return;
            }

            Head.Previous.Previous.Next = Head;
            Head.Previous = Head.Previous.Previous;

            _count--;
        }

        public void Clear()
        {
            if (Head != null)
            {
                Head.Previous.Next = null;
                Head = null;
            }

            _count = 0;
        }
    }
}
