using System;
using Algorithms_DS.Trees;

namespace AlgorithmsDS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] input = {5,1,2,4,6,3,0};
            Tree tree = new Tree();
            tree.ConstructTree(input);
            tree.Inorder();
            tree.PostOrder();
            tree.PreOrder();
            var root = tree.GetRoot();
            Console.WriteLine("Root:{0}",root.data);

            int[] input2 = {1,1,1,1,1,};
            Tree tree2 = new Tree();
            tree2.ConstructTree(input2);
            tree2.PostOrder();
            var uniq = new UniqValuesTree();
            Console.WriteLine(uniq.IsUniqvalTree(tree2.GetRoot()));
            Console.Read();
        }
    }
}
