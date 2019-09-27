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

        public void InsertAt(int item,int index)
        {
            int newCount = items.Length + 1;
            int[] newItems = new int[newCount];
            for(int i = 0, j=0;i<count;i++,j++)
            {
                if(j==index)
                 {
                     newItems[j] = item;
                     i--;
                 }
                 else
                 {
                    newItems[j] = items[i];
                 }
            }
            items = newItems;
            count++;
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

        public Array Insersect(Array someItems)
        {
            Array commonArray = new Array(items.Length);
            int commonCount = 0;
            for(int i =0; i<count;i++)
            {
                for(int j=0;j<someItems.count;j++)
                {
                    if(items[i] == someItems.items[j])
                    {
                     commonArray.items[commonCount] = items[i];
                     commonCount++;
                    }
                }
            }

            if(commonCount > 0)
            {
              commonArray.count = commonCount;
              return commonArray;
            }
             
            return null;
        }

        public int[] ReverseArray()
        {
            if(count == 0)
                return null;

            for(int i=0;i<count-1;i++)
            {
                int temp = items[i];
                items[i] = items[count - i -1];
                items[count - i -1] = temp;
            }
            
            return items;
        }
    }
}