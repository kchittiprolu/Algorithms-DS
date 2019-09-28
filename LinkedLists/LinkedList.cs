using System;

namespace Algorithms_DS.LinkedLists
{
    public class LinkedList
    {
        private class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
        private Node first;
        private Node last;
        private int size;

        public int Size()
        {
            return size;
        }

        public int[] ToArray()
        {
            int[] array = new int[size];
            var current = first;
            int index = 0;
            while(current != null)
            {
             array[index++] = current.value;
             current = current.next;
            }
            return array;
        }
        public void RemoveFirst()
        {
            if(IsEmpty())
            throw new InvalidOperationException();
           
            if(first == last){
                first = last = null;
                return;
            }
            var newFirst = first.next;
            first.next = null;
            first = newFirst;
            size --;
        }

        public void RemoveLast()
        {
            if(IsEmpty())
             throw new InvalidOperationException();

             if(first == last)
             {
                 first = last = null;
                 size--;
                 return;
             }
            var current = first;
            while(current != null)
            {
                if(current.next == last)
                {
                    current.next = null;
                    last = current;
                    break;
                }
                current = current.next;
            }
            size--;
        }
        public bool Contains(int item)
        {
            return IndexOf(item) != -1;
        }
        public int IndexOf(int item)
        {
            int index = 0;
            var current = first;
            while(current != null)
            {
                if(current.value == item)
                 return index;
                index++;
                current = current.next;
            }
            return -1;
        }
        public void AddFirst(int item)
        {
            Node node = new Node(item);
            if(IsEmpty())
               first = last = node;
            else{
                node.next = first;
                first = node;
            }
            size++;
        }
        public void AddLast(int item)
        {
            Node node = new Node(item);
            if(IsEmpty())
               first = last = node;
            else
            {
               last.next = node;
               last = node;
            }
            size++;
        }

        private bool IsEmpty()
        {
            return first == null;
        }
    }
}