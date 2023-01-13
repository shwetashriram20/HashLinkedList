using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashLinkedList
{
    public class LinkedList<K, V> where K : IComparable
    {
        public HashNode<K, V> Head;
        public HashNode<K, V> Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        internal HashNode<K, V> Search(K Key)
        {
            HashNode<K, V> temp = Head;
            while (temp != null)
            {
                if (temp.Key.Equals(Key))
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public void Append(HashNode<K, V> node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
        }
    }
}
