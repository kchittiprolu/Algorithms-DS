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
            Tree tree1 = new Tree();
            tree1.ConstructTree(input);
            tree1.Inorder();
            tree1.PostOrder();
            tree1.PreOrder();
            var root = tree1.GetRoot();
            Console.WriteLine("Root:{0}",root.data);

            int[] input2 = {1,1,1,1,1,};
            Tree tree2 = new Tree();
            tree2.ConstructTree(input2);
            tree2.PostOrder();
            var uniq = new UniqValuesTree();
            Console.WriteLine(uniq.IsUniqvalTree(tree2.GetRoot()));

            Tree tree3 = new Tree();
            tree3.ConstructTree(new int[] {1,2,3,4,9});
            tree3.PostOrder();

            var merge = new MergeTwoBinaryTrees();
            var mergedTree = merge.MergeTrees(tree1.GetRoot(),tree3.GetRoot());
            Tree tree = new Tree();
            Console.WriteLine("Merged Tree:");
            tree.PreOrderTraversal(mergedTree);

            Console.Read();
        }
    }
}
