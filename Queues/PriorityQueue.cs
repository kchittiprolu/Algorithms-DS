using System.Text;
using System;
namespace Algorithms_DS.Queues
{
    public class PriorityQueue
    {
        private int[] items;
        private int count;
        public PriorityQueue(int capacity)
        {
            items = new int[capacity];
        }

        public void Add(int item)
        {
            if(IsFull())
            throw new InvalidOperationException();
            var i = ShiftItemsToInsert(item);
            items[i] = item;
            count++;
        }
        
        private int ShiftItemsToInsert(int item)
        {
            int i;
            for(i=count-1; i>=0;i--)
            {
                if(items[i] > item)
                 items[i+1] = items[i];
                 else
                  break;
            }
            return i+1;
        }
        public int Remove()
        {
            if(IsEmpty())
             throw new InvalidOperationException();
            int temp = items[count-1];
            items[--count] = 0;
            return temp;
        }

        public bool IsEmpty()
        {
            return count==0;
        }

        public bool IsFull()
        {
            return count == items.Length;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for(int i=0;i<items.Length;i++)
            {
                sb.Append(items[i]);
                if(i+1!=items.Length)
                   sb.Append(",");
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}