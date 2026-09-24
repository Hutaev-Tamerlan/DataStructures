using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class DoublyLinkedList<T>
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

        public void PrintReverse()
        {
            Node<T> current = Tail;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Previous;
            }

            Console.WriteLine();
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
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
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
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

            if (Tail.Data.Equals(data))
            {
                RemoveLast();
                return;
            }

            Node<T> current = Head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
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
            else
            {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (Tail == null)
            {
                return;
            }

            Tail = Tail.Previous;
            _count--;

            if (Tail == null)
            {
                Head = null;
            }
            else
            {
                Tail.Next = null;
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            _count = 0;
        }
    }
}
