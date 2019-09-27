using System;
using Algorithms_DS.Trees;
using Algorithms_DS.Arrays;
using Algorithms_DS.Strings;
namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithms_DS.Arrays.Array a = new Algorithms_DS.Arrays.Array(2);
            a.Insert(30);
            a.Insert(40);
            a.Insert(50);
            a.Print();
            Algorithms_DS.Arrays.Array b = new Algorithms_DS.Arrays.Array(2);
            b.Insert(10);
            b.Insert(20);
            b.Insert(50);
            b.Print();
        }
    }
}
