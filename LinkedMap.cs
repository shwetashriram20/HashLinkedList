using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashLinkedList
{
    public class LinkedMap<K, V> where K : IComparable
    {
        private readonly int NumBuckets;
        readonly List<LinkedList<K, V>> BucketList;

        public LinkedMap(int NumBuckets)
        {
            this.NumBuckets = NumBuckets;
            BucketList = new List<LinkedList<K, V>>(NumBuckets);

            for (int i = 0; i < NumBuckets; i++)
                BucketList.Add(null);
        }
        public V Get(K Key)
        {
            int Index = GetIndex(Key);
            LinkedList<K, V> linkedlist = BucketList[Index];
            if (linkedlist == null)
                return default;
            HashNode<K, V> hashnode = linkedlist.Search(Key);
            return (hashnode == null) ? default : hashnode.Value;
        }
        public int GetIndex(K Key)
        {
            int HashCode = Math.Abs(Key.GetHashCode());
            int Index = HashCode % NumBuckets;
            return Index;
        }
        public void Add(K Key, V Value)
        {
            int Index = GetIndex(Key);
            LinkedList<K, V> linkedlist = BucketList[Index];

            if (linkedlist == null)
            {
                linkedlist = new LinkedList<K, V>();
                BucketList[Index] = linkedlist;
            }
            HashNode<K, V> hashnode = linkedlist.Search(Key);
            if (hashnode == null)
            {
                hashnode = new HashNode<K, V>(Key, Value);
                linkedlist.Append(hashnode);
            }
            else hashnode.Value = Value;
        }
    }
}



