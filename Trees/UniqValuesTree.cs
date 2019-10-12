namespace Algorithms_DS.Trees
{
    #region Question
    // A binary tree is univalued if every node in the tree has the same value.
    // Return true if and only if the given tree is univalued.
    // Example 1:
    // Input: [1,1,1,1,1,null,1]
    // Output: true
    //For Execution:(copy & paste below code in Main method)
    // int[] input2 = {1,1,1,1,1,};
    // Tree tree2 = new Tree();
    // tree2.ConstructTree(input2);
    // tree2.PostOrder();
    // var uniq = new UniqValuesTree();
    // Console.WriteLine(uniq.IsUniqvalTree(tree2.GetRoot()));
    #endregion
    public class UniqValuesTree
    {
        public bool IsUniqvalTree(TreeNode root){
            if(root == null)
            return true;

            return (root.left == null || root.data == root.left.data && IsUniqvalTree(root.left)) &&
            (root.right == null || root.data==root.right.data && IsUniqvalTree(root.right));
        }
        
    }
}