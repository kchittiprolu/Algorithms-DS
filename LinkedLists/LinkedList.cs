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

        public int[] FindMiddle()
        {
            var slow = first;
            var fast = first;
            while(fast != last && fast.next != last)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            if(fast == last)
                return new int[] {slow.value};
            else
            return new int[] {slow.value, slow.next.value};
        }

        public int GetKthFromTheEnd(int k)
        {
            if(IsEmpty())
            throw new NullReferenceException();
            var a = first;
            var b = first;

            for(int i=0;i<k-1;i++)
            {
                b = b.next;
                if(b == null)
                throw new ArgumentOutOfRangeException();
            }
                while(b != last)
                {
                    a = a.next;
                    b = b.next;
                }
                return a.value;
        }

        public void ReverseInline()
        {
            if(IsEmpty())
            return;
            var prev = first;
            var current = first.next;
            while(current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            last = first;
            last.next = null;
            first = prev;
        }
        public void Reverse()
        {
            if(IsEmpty())
            return;
            LinkedList newList = new LinkedList();
            var current = first;
            while(current != null)
            {
                 newList.AddFirst(current.value);
                 current = current.next;
            }
            
            first = newList.first;
            last = newList.last;
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