using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        private int size;
        private Node head;

        public LinkedList()
        {
            this.size = 0;
            this.head = null;
        }

       
        public void insertNode(int data)
        {
            Node node = new Node();
            node.data = data;
            Node current = this.head;

            if (this.head == null)
            {
                this.head = node;
                this.head.next = null;
                this.size = 1;
                Console.WriteLine(this.head);
            }
            else
            {

                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                node.next = null;
                this.size += 1;
            }
        }
        public void insertN(int data, int position)
        {
            Node node = new Node();
            node.data = data;
            Node current = this.head;
            if (this.head != null && position <= this.size)
            {
                for (int i = 1; i < position; i++)
                {
                    current = current.next;
                }
                node.next = current.next;
                current.next = node;
                this.size += 1;
            }
            else
            {
                Console.WriteLine("Exceeded the linked list size. Current Size: " + size);
            }
        }
        public void deleteFirstNode()
        {
            if (head != null)
            {
                this.head = this.head.next;
                this.size--;
            }
            else
            {
                Console.WriteLine("Linked list is empty");
            }
        }
        public void deleteLastNode()
        {
            Node currentNode = this.head;
            if (size == 1)
            {
                head = null;
                size = 0;
            }
            else
            {
                Node prevNode = null;
                while (currentNode.next != null)
                {
                    prevNode = currentNode;
                    currentNode = currentNode.next;
                }
                prevNode.next = null;
                this.size--;
            }
        }
        public void findNode(int data)
        {
            Node node = this.head;
            bool found = false;
            for (int i = 0; i < size; i++)
            {
                if (node.data == data)
                {
                    Console.WriteLine("data " + data + " found at location " + i + " in the linked list");
                    found = true;
                }
                node = node.next;
            }

            if (!found)
                Console.WriteLine("data " + data + " not found in the Linked list");
        }
        public void deleteNNode(int position)
        {
            if (position <= this.size && this.head != null)
            {
                Node currentNode = this.head;
                Node preNode = null;
                for (int i = 0; i < position; i++)
                {
                    preNode = currentNode;
                    currentNode = currentNode.next;
                }
                preNode.next = currentNode.next;
                this.size--;
            }
            else
            {
                Console.WriteLine("No node exist : " + position);
            }
        }
        public void orderNodes()
        {
            if (this.size < 1)
                Console.WriteLine("There are no nodes in the linked list");

            else
            {
                Node current = this.head;


                for (int i = 0; i < this.size - 2; i++)
                {
                    for (int j = 0; j < this.size - 2; j++)
                    {
                        while (current.next != null)
                        {
                            if (current.data > current.next.data)
                            {
                                int temp = current.next.data;
                                current.next.data = current.data;
                                current.data = temp;
                            }
                            current = current.next;
                        }
                    }
                }
                current = this.head;
                Console.WriteLine("sorted order is :");
                for (int i = 0; i < this.size; i++)
                {
                    Console.WriteLine("Node " + current.data + " is at location " + i);
                    current = current.next;
                }

            }
        }
        public void printNodes()
        {
            if (this.size < 1)
                Console.WriteLine("There are no nodes in the linked list");

            else
            {
                Node current = this.head;
                for (int i = 0; i < this.size; i++)
                {
                    Console.WriteLine("Node " + current.data + " is at location " + i);
                    current = current.next;
                }
            }
        }


        public int getListSize()
        {
            return size;
        }

    }
}
