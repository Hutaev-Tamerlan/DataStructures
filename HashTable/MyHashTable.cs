using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class MyHashTable<TKey, TValue>
    {
        private Node<TKey, TValue>[] _buckets;
        private int _capacity;
        private int _count;

        public MyHashTable(int capacity = 16)
        {
            _capacity = capacity;
            _buckets = new Node<TKey, TValue>[_capacity];
            _count = 0;
        }

        private int GetBucketIndex(TKey key)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }

            int index = key.GetHashCode() % _capacity;

            if (index < 0)
            {
                return index + _capacity;
            }

            return index;
        }

        public TValue this[TKey key]
        {
            get
            {
                if (Find(key, out TValue value))
                {
                    return value;
                }
                throw new KeyNotFoundException($"Key '{key}' was not found in the table");
            }
            set
            {
                Add(key, value);
            }
        }

        public int Count()
        {
            return _count;
        }

        public bool ContainsKey(TKey key)
        {
            return Find(key, out _);
        }

        public void Add(TKey key, TValue value)
        {
            int index = GetBucketIndex(key);
            Node<TKey, TValue> current = _buckets[index];

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    current.Value = value;
                    return;
                }

                current = current.Next;
            }

            var newNode = new Node<TKey, TValue>(key, value) { Next = _buckets[index] };
            _buckets[index] = newNode;
            _count++;
        }

        public bool Find(TKey key, out TValue value)
        {
            int index = GetBucketIndex(key);
            Node<TKey, TValue> current = _buckets[index];

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    value = current.Value;
                    return true;
                }

                current = current.Next;
            }

            value = default;
            return false;
        }

        public bool Remove(TKey key)
        {
            int index = GetBucketIndex(key);
            Node<TKey, TValue> current = _buckets[index];
            Node<TKey, TValue> previous = null;

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    if (previous == null)
                    {
                        _buckets[index] = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }

                    _count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            Array.Clear(_buckets, 0, _buckets.Length);
            _count = 0;
        }
    }
}
