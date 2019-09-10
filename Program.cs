using System;
using Algorithms_DS.Trees;
using Algorithms_DS.Arrays;

namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var binGap = new MaxBinaryGapInArray();
            Console.WriteLine("Max binary gap:{0}",binGap.MaxbinaryGap(1041));
            Console.Read();
        }
    }
}
