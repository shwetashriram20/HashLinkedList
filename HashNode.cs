using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashLinkedList
{
    public class HashNode<K, V>
    {
        public K Key;
        public V Value;
        public HashNode<K, V> Next;

        public HashNode(K Key, V Value)
        {
            this.Key = Key;
            this.Value = Value;
            Next = null;
        }
    }
}

