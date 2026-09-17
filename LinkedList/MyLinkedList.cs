using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    internal class MyLinkedList<T>
    {
        public Node<T> Head { get; private set; } = null;

        public void Print()
        {
            Node<T> current = Head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = Head;
            Head = newNode;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }

        public void AddRangeLast(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                AddLast(item);
            }
        }

        public void AddRangeFirst(IEnumerable<T> items)
        {
            foreach (T item in items.Reverse())
            {
                AddFirst(item);
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
                return;
            }

            Node<T> current = Head;

            while (current.Next != null)
            {
                if (current.Next.Data.Equals(data))
                {
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
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
                return;
            }

            Node<T> current = Head;

            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }

            Head = Head.Next;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}
