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
      public TreeNode Insert(TreeNode root, int data){
            if(root == null)
            return new TreeNode(data);
            else{
                TreeNode curr;
                if(data <= root.data){
                    curr = Insert(root.left, data);
                    root.left = curr;
                }
                else{
                    curr = Insert(root.right,data);
                    root.right = curr;
                }
                return root;
            }
      }

        public void Traverse(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Traverse(root.left);
            Traverse(root.right);
        }
        public void ConstructTree(int[] input){
            TreeNode root = null;
            foreach(int i in input){
                root = Insert(root, i);
            }
        }
    }
}