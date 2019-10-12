using System;

namespace Algorithms_DS.Arrays
{
    #region Problem
        // Find the maximum binary gap in a binary equivalent of given integer N. 
        // For example, binary representation of integer 1041 is 10000010001, we identify 5 zeroes between first occurrence of 1 and second occurrence of 1 and we find 3 zeroes 
        // between second occurrence of 1 and third occurrence of 1. so the maximum binary gap is 5.
        //For Execution: (copy past below code in Main method)
        // var binGap = new MaxBinaryGapInArray();
        // Console.WriteLine("Max binary gap:{0}",binGap.MaxbinaryGap(1041));
    #endregion

    public class MaxBinaryGapInArray
    {
        public int MaxbinaryGap(int number)
        {
            string binary = Convert.ToString(number, 2);
            char[] digits = binary.ToCharArray();
            int max = 0;
            int current = -1;

            foreach (var item in digits)
            {
                var num = Char.GetNumericValue(item);
                if (num == 1)
                {
                    current = current > 0 ? current : 0;
                    max = current > 0 && current > max ? current : max;
                    current = 0;
                }
                else
                    current++;
            }
            return max;
        }
    }
}