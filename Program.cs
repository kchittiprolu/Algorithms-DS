using System;
using Algorithms_DS.Trees;
using Algorithms_DS.Arrays;
using Algorithms_DS.Strings;
using Algorithms_DS.LinkedLists;
using Algorithms_DS.Queues;
using System.Collections.Generic;
namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(FirstNonRepeatingChar("a green apple"));
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
    }
}
