using System;
using System.Text;
using Algorithms_DS.Stacks;
namespace Algorithms_DS.Queues
{
    public class ArrayQueue
    {
        private int[] items;
        private int count;
        private int rear;
        private int front;
        public ArrayQueue(int capacity)
        {
            items = new int[capacity];    
        }

        public void Enqueue(int item)
        {
            if(items.Length == count)
              throw new ArgumentOutOfRangeException();
            
            items[rear] = item;
            rear = (rear + 1) % items.Length;
            count++;
        }

        public int Dequeue()
        {
            if(count == front)
             throw new ArgumentOutOfRangeException();
            var item = items[front];
            items[front] = 0;
            front = (front + 1) % items.Length;
            count--;
            return item;
        }

        public bool IsEmtpy()
        {
            return count == 0;
        }

        public int[] Reverse()
        {
            Stack st = new Stack(10);
            int index = count;
            while(!IsEmtpy())
             st.Push(Dequeue());
            while(!st.IsEmpty())
             Enqueue(st.Pop());
            return null;
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