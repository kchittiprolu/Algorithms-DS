using System;
using System.Collections.Generic;
public class Graph
{
 private Dictionary<string, Node> Nodes = new Dictionary<string, Node>();
 private Dictionary<Node,List<Node>> AdjacencyList = new Dictionary<Node, List<Node>>();
    private class Node 
    {
        private string Label {get;set;}
        public Node(string label)
        {
            this.Label = label;
        }

        public override string ToString()
        {
            return this.Label;
        }
    } 

 public void AddNode(string label)
 {
   var node = new Node(label);
   if(Nodes.TryAdd(label,node))
   {
        AdjacencyList.Add(node,new List<Node>());
   }
 }

 public void AddEdge(string from, string to)
 {
     if(Nodes[from] == null)
      throw new KeyNotFoundException();

      if(Nodes[to]==null)
      throw new KeyNotFoundException();

      var fromNode = Nodes[from];
      var toNode = Nodes[to];
      AdjacencyList[fromNode].Add(toNode); //we are adding edge in directional graph.
 }

 public void RemoveNode(string label)
 {
     var val = new Node("");
     if(!Nodes.TryGetValue(label,out val))
        return;
     foreach (var list in AdjacencyList.Values)
     {
         list.Remove(val);
     }
     AdjacencyList.Remove(val);
     Nodes.Remove(label);
 }

 public void RemoveEdge(string from, string to)
 {
     var fromVal = new Node("");
     if(!Nodes.TryGetValue(from,out fromVal))
        return;
     var toVal = new Node("");
     if(!Nodes.TryGetValue(to,out toVal))
        return;

    AdjacencyList[fromVal].Remove(toVal);
 }

 public void Print()
 {
     foreach (var item in AdjacencyList)
     {
         foreach (var connecion in item.Value)
         {
             Console.WriteLine("{0} is connected to {1}",item.Key,connecion.ToString());
         }
     }
 }
}