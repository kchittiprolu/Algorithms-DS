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
         var graph = new Graph();
         graph.AddNode("Karthik");
         graph.AddNode("KarthikKurella");
         graph.AddNode("Harish");
         graph.AddNode("Sasi");
         graph.AddEdge("Karthik","KarthikKurella");
         graph.AddEdge("KarthikKurella","Harish");
         graph.AddEdge("Harish","Karthik");
         graph.AddEdge("KarthikKurella","Sasi");
         graph.Print();
         graph.RemoveEdge("Karthik","KarthikKurella");
         graph.Print();
        }
    }
}
