using System;
using Algorithms_DS.Trees;
using Algorithms_DS.Arrays;
using Algorithms_DS.Strings;
using Algorithms_DS.LinkedLists;
namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
          LinkedList list = new LinkedList();
          list.AddLast(10);
          list.AddLast(20);
          list.AddLast(30);
          Console.WriteLine(list.IndexOf(20));
          Console.WriteLine(list.Contains(10));
          //list.RemoveLast();
          Console.WriteLine(list.Size());
          foreach(var item in list.ToArray())
          {
            Console.WriteLine(item);
          }
        }
    }
}
