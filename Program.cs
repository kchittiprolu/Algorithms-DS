using System;
using Algorithms_DS.Trees;
using Algorithms_DS.Arrays;

namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoSum = new TwoSum();
            var result = twoSum.TwoSumProblem(9,new int[] {2,7,11,15});
            Console.WriteLine("Indeces of two numbers: [{0}] ", string.Join(",",result));
        }
    }
}
