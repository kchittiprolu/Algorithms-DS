using System;
using Algorithms_DS.Trees;
using Algorithms_DS.Arrays;
using Algorithms_DS.Strings;
using Algorithms_DS.LinkedLists;
using Algorithms_DS.Queues;
using System.Collections.Generic;
using Algorithms_DS.HashTables;
namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
         Tree t = new Tree();
         t.Insert(7);
         t.Insert(4);
         t.Insert(9);
         t.Insert(8);
         t.Insert(10);
         t.Insert(1);
         t.Insert(6);
        //  Tree other = new Tree();
        //  other.Insert(7);
        //  other.Insert(4);
        //  other.Insert(9);
        //  other.Insert(8);
        //  other.Insert(10);
        //  other.Insert(1);
        //  other.Insert(6);
        //  Console.WriteLine(t.Equal(other));
         var list = t.PrintNodesAtDistance(2);
         foreach (var item in list)
         {
             Console.WriteLine(item);
         }
        // t.SwapRoot();
        // Console.WriteLine(t.IsBinarySearchTree());
        //  t.PreOrder();
        //  Console.WriteLine("Height of Tree: {0}",t.Height());
        //  Console.WriteLine("Min Value of Tree: {0}",t.MinOfTree());
        }
    }
}
