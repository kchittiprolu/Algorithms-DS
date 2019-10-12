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
          HashTable table = new HashTable();
          table.Put(6,"A"); //1
          table.Put(8,"B"); //3
          table.Put(11,"C"); //1
          table.Put(11,"K");
          table.Remove(11);
          Console.WriteLine(table.Get(11));
          
        }

        static char FirstNonRepeatingChar(string input)
        {
          var dict = new Dictionary<char,int>();
          for(int i=0;i<input.Length;i++)
          {
            if(dict.ContainsKey(input[i])){
              dict[input[i]]++;
            }
            else
               dict.Add(input[i],1);
          }
          foreach (var item in dict)
          {
              if(dict[item.Key] == 1)
              return item.Key;
          }
          return char.MinValue;
        }

        static char FirstRepeatedChar(string input)
        {
          var set = new HashSet<int>();
          foreach (char c in input)
          {
              if(set.Contains(c))
                 return c;
               set.Add(c);
          }
          return char.MinValue;
        }
    }
}
