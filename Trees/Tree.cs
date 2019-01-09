using System;
namespace Algorithms_DS.Trees
{
    public class TreeNode
    {
     public int data;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { data = x; }
    }

    public class Tree{
        TreeNode root;
        public Tree(){
            root = null;
        }

    public TreeNode GetRoot(){
        return root;
    }
     public void Insert(int data){
         root = InsertNode(root,data);
     }
      private TreeNode InsertNode(TreeNode root, int data){
            if(root == null){
            root= new TreeNode(data);
            return root;
            }

        if(data <= root.data)
            root.left = InsertNode(root.left, data);
        else
            root.right = InsertNode(root.right,data);
        
        return root;
      }

      public void PostOrder(){
           Console.WriteLine("PostOrder Traversal:");
          PostOrderTraversal(root);
      }
        private void PostOrderTraversal(TreeNode root) { 
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
        private void PreOrderTraversal(TreeNode root) { 
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
    private void InorderRec(TreeNode root) { 
        if (root != null) { 
            InorderRec(root.left); 
            Console.WriteLine(root.data); 
            InorderRec(root.right); 
        } 
    } 
        public void ConstructTree(int[] input){
            foreach(int i in input){
                 Insert(i);
            }
        }
    }
}