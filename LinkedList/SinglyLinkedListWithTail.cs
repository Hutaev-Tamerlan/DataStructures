using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class SinglyLinkedListWithTail<T>
    {
        private Node<T> Head { get; set; } = null;
        private Node<T> Tail { get; set; } = null;

        private int _count = 0;
        public int Count { get { return _count; } }

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

            if (Tail == null)
            {
                Tail = Head;
            }

            _count++;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
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

            if (Head.Data.Equals(data))
            {
                RemoveFirst();
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    if (current.Next == Tail)
                    {
                        Tail = current;
                    }

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

            if (Head == null)
            {
                Tail = null;
            }
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
                Tail = null;
                _count--;
                return;
            }

            Node<T> current = Head;

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
            Tail = current;
            _count--;
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            _count = 0;
        }
    }
}
