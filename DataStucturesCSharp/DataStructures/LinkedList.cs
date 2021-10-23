using DataStucturesCSharp.DataStructures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStucturesCSharp.DataStructures
{

    internal class Node<T>
    {
        internal T data;
        internal Node<T> next;
        public Node(T d)
        {
            data = d;
            next = null;
        }
    }

    class LinkedList<T> : IGenericCollection<T>
    {

        // Declare a single-dimensional array of 5 integers.
        private int[] arr;
        private Node<T> head;

        LinkedList()
        {
            head = null;
        }

        int IGenericCollection<T>.Count => throw new NotImplementedException();

        public void Add(T item)
        {
            Node<T> new_node = new Node<T>(item);

            if (head == null)
            {
                head = new_node;
                head.next = null;
            }
            else
            {
                new_node.next = head;
                head = new_node;
            }
        }

        public Node<T> GetLastNode()
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void Clear()
        {
            head = null;
            head.next = null;
        }

        public bool Compare<T>(T x, T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y);
        }

        public bool Contains(T item)
        {
            Node<T> temp = head;
            while (temp.next != null)
            {
                var comparison = Compare(temp.data, item);
                if (comparison)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
