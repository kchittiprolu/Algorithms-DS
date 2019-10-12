using System;
using System.Text;
namespace Algorithms_DS.Stacks
{
    public class Stack
    {
        private int[] items;
        private int count = 0;
        public Stack(int capacity)
        {
            items = new int[capacity];
        }
        public void Push(int item)
        {
            if(count == items.Length)
                throw new StackOverflowException();
            items[count++] = item;
        }

        public int Pop()
        {
            if(count == 0)
            throw new ArgumentOutOfRangeException();
            return items[--count];
        }

        public int Peek()
        {
            if(count == 0)
             throw new ArgumentOutOfRangeException();
            return items[count-1];
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

        public bool IsEmpty()
        {
            return count==0;
        }
    }
}