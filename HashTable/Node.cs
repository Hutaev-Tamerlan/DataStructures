using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Node<TKey, TValue>
    {
        public TKey Key { get; }
        public TValue Value { get; set; }
        public Node<TKey, TValue> Next { get; set; }

        public Node(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }
}
