using System;
using System.Collections.Generic;
namespace Algorithms_DS.Trees
{
    public class Node
    {
     public int data;
      public Node left;
      public Node right;
      public Node(int x) { data = x; }
    }

    public class Tree{
        Node root;
        public Tree(){
            root = null;
        }

    public Node GetRoot(){
        return root;
    }
     public void Insert(int data){
         root = InsertNode(root,data);
     }
      private Node InsertNode(Node root, int data){
            if(root == null){
            root= new Node(data);
            return root;
            }

        if(data <= root.data)
            root.left = InsertNode(root.left, data);
        else
            root.right = InsertNode(root.right,data);
        
        return root;
      }

      public bool Find(int data)
      {
          return FindNode(root,data);
      }

      private bool FindNode(Node root, int data)
      {
        if(root.data == data)
         return true;
        if(root == null || root.left == null || root.right == null)
          return false;
        if (root.left != null && data < root.data)
        return FindNode(root.left,data);
        else
        return FindNode(root.right,data);
      }

      public void PostOrder(){
           Console.WriteLine("PostOrder Traversal:");
          PostOrderTraversal(root);
      }
        public void PostOrderTraversal(Node root) { 
        if (root != null) { 
            PostOrderTraversal(root.left); 
            PostOrderTraversal(root.right); 
            Console.WriteLine(root.data); 
        } 
      } 

      public void PreOrder(){
         Console.WriteLine("PreOrder Traversal:");
        PreOrderTraversal(root);
      }
        public void PreOrderTraversal(Node root) { 
            if (root != null) { 
                Console.WriteLine(root.data); 
                PreOrderTraversal(root.left); 
                PreOrderTraversal(root.right); 
            } 
        } 
        public void Inorder()  { 
            Console.WriteLine("InOrder Traversal:");
            InorderRec(root); 
            } 
  
    // A utility function to do inorder traversal of BST 
    public void InorderRec(Node root) { 
        if (root != null) { 
            InorderRec(root.left); 
            Console.WriteLine(root.data); 
            InorderRec(root.right); 
        } 
    } 

    //Calculate height of a tree (height of the root node)
    public int Height()
    {
        return HeightOfTree(root);
    }

    private int HeightOfTree(Node root)
    {
        if(root == null)
        return -1;
        if(root.left == null && root.right == null)
        return 0;
        return 1 + Math.Max(HeightOfTree(root.left),HeightOfTree(root.right));
    }

    public int MinOfTree()
    {
        return MinVal(root);
    }

    private int MinVal(Node root)
    {
        var current = root;
        var last = current;
        while(current != null)
        {
            last = current;
            current = current.left;
        }
       return last.data;
    }

    //Finding min value of binary tree
    private int MinValBT(Node root)
    {
        if(root.left == null && root.right == null)
         return root.data;
        var left = MinValBT(root.left);
        var right = MinValBT(root.right);
        return Math.Min(Math.Min(left,right),root.data);
    }

    public bool Equal(Tree other)
    {
        if(other == null)
          return false;
       return Equality(root,other.GetRoot());
    }

    private bool Equality(Node first, Node second)
    {
      if(first == null && second == null)
         return true;
      if(first != null && second !=null)
         return first.data == second.data && Equality(first.left,second.left) && Equality(first.right,second.right);
      return false; 
    }
    
    //Swap the left and right elements of root.
    //This function is just to test if "IsBinarySearchTree()" is validating correctly if a wrong BST is supplied.
    public void SwapRoot()
    {
        var temp = root.left;
        root.left = root.right;
        root.right = temp;
    }
    public bool IsBinarySearchTree()
    {
        return IsBST(root, int.MinValue,int.MaxValue);
    }
    private bool IsBST(Node root, int min, int max)
    {
        if(root == null)
           return true;
        if(root.data < min || root.data > max)
           return false;
           
        return IsBST(root.left, min, root.data - 1) && IsBST(root.right, root.data+1,max);
    }

    public List<int> PrintNodesAtDistance(int distance)
    {
        var resultList = new List<int>();
        PrintNodesAtDistance(root,distance,resultList);
        return resultList;
    }
    private void PrintNodesAtDistance(Node root, int distance,List<int> resultList)
    {
        if(root == null)
           return;
        if(distance == 0)
        {
            resultList.Add(root.data);
            return;
        }
        PrintNodesAtDistance(root.left,distance-1,resultList);
        PrintNodesAtDistance(root.right,distance-1,resultList);
    }

    public void ConstructTree(int[] input)
    {
        foreach(int i in input)
        {
                Insert(i);
        }
    }
    }
}