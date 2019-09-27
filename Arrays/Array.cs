using System;
namespace Algorithms_DS.Arrays
{
    public class Array
    {
        private int[] items;
        private int count;
        public Array(int length)
        {
            items = new int[length];
        }

        public void Print()
        {
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(items[i]);
            }
        }

        //If array is full, resize it
        //Add the new item at the end.
        public void Insert(int item)
        {
            if(items.Length == count)
            {
               int[] newItems = new int[count * 2];
               for(int i =0; i<count;i++)
               {
                   newItems[i] = items[i];
               } 
               items = newItems;
            }
            items[count++] = item;
        }

        public void RemoveAt(int index)
        {
            if(index < 0 || index >= count)
             throw new IndexOutOfRangeException();

            for(int i= index;i<count;i++)
                items[i] = items[i+1];

            count--;
        }

        public int IndexOf(int item)
        {
            for(int i=0;i<count;i++)
            {
                if(items[i] == item)
                 return i;
            }
            return -1;
        }

        public int Max()
        {
            int max = Int32.MinValue;
            for(int i=0;i<count;i++)
            {
                if(items[i] > max)
                max = items[i];
            }
            return max;
        }

        public int[] Insersect(int[] someItems)
        {
            int[] commonArray = new int[items.Length];
            int commonCount = 0;
            for(int i =0; i<count;i++)
            {
                for(int j=0;j<someItems.Length;j++)
                {
                    if(items[i] == someItems[j])
                    {
                     commonArray[commonCount] = items[i];
                     commonCount++;
                    }
                }
            }
            if(commonCount > 0)
             return commonArray;
             
            return null;
        }
    }
}