using Algorithms_DS.Stacks;
using System.Collections.Generic;
using System;
using System.Text;
namespace Algorithms_DS.Queues
{
    public class Queue
    {
        private int[] items;
        private int count;
        private int rear;

        public bool IsEmpty()
        {
            return count == 0;
        }
        public Queue(int capacity)
        {
            items = new int[capacity];
        }
        public void Enqueue(int item)
        {
            if(items.Length == count)
                throw new ArgumentOutOfRangeException();
            items[rear++] = item;
            count++;
        }

        public int Dequeue()
        {
            return 0;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var item in items)
            {
                sb.Append(item);
                if(item != items[count-1])
                   sb.Append(",");
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}