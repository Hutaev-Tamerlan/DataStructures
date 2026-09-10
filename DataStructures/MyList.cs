using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    internal class MyList<T>
    {
        private T[] _items;
        private int _capacity = 4;
        private int _count;

        public int Count { get { return _count; } }

        public MyList()
        {
            _items = new T[_capacity];
            _count = 0;
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }

            _items[_count] = item;
            _count++;
        }

        public void AddRange(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Add(item);
            }
        }

        public void Remove(T item)
        {
            for (int i = 0; i < _count;  i++)
            {
                if (item.Equals(_items[i]))
                {
                    RemoveAt(i);
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count --;
        }

        public void Clear()
        {
            _count = 0;
        }

        public void Insert(int index, T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }

            for (int i = _count; i > index; i--)
            {
                _items[i] = _items[i - 1];
            }

            _items[index] = item;
            _count++;
        }

        private void Resize()
        {
            T[] newArray = new T[_count * 2];

            for (int i = 0; i < _count; i++)
            {
                newArray[i] = _items[i];
            }

            _items = newArray;
        }
    }
}
