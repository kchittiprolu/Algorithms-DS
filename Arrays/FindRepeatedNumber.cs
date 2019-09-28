using System;
using System.Collections.Generic;

namespace Algorithms_DS.Arrays
{
        #region Problem
        // Problem 1:  Out of all number in an Array only one number will appear once and rest will appear multiple times.Find that unique number.
        // Problem 2: // Out of all number in an Array only one number will repeat multiple times and rest of numbers only appear once.Find that repeated number.
        // For Execution: (copy past below code in Main method)
        //  var repeat = new FindRepeatedNumber();
        //  Console.WriteLine("Repeated number: {0}", repeat.RepeatedNTimes(new int[]{5,4,5,2,5,3,3,4}));
        //  Console.WriteLine("Unique number: {0}", repeat.UniqueNumber(new int[]{5,4,5,2,5,3,3,4}));
    #endregion
    public class FindRepeatedNumber
    {
#region Problem1
// Out of all number in an Array only one number will appear once and rest will appear multiple times.
// Find that unique number.
#endregion
        public int UniqueNumber(int[] a)
        {
            var nums = new Dictionary<int,int>();
            int number = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(nums.ContainsKey(a[i]))
                   nums[a[i]]++;
                else
                   nums.Add(a[i],1);
            }

            foreach(var item in nums)
            {
                if(item.Value == 1)
                   {
                       number = item.Key;
                       break;
                   }
            }
            return number;
        }

#region Problem2
// Out of all number in an Array only one number will repeat multiple times and rest of numbers only appear once.
// Find that repeated number.
#endregion
        public int RepeatedNTimes(int[] a)
        {
            var nums = new Dictionary<int,int>();
            int number = 0;
            for(int i=0;i<a.Length;i++)
            {
                if(nums.ContainsKey(a[i]))
                   nums[a[i]]++;
                else
                   nums.Add(a[i],1);
            }

            foreach(var item in nums)
            {
                if(item.Value > 1)
                   {
                       number = item.Key;
                       break;
                   }
            }
            return number;
        }
    }
}