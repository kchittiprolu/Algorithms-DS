namespace Algorithms_DS.Trees
{
 #region Question
// Given two binary trees and imagine that when you put one of them to cover the other, 
//some nodes of the two trees are overlapped while the others are not.
// You need to merge them into a new binary tree. The merge rule is that if two nodes overlap, 
//then sum node values up as the new value of the merged node. Otherwise, the NOT null node will be used as the node of new tree.
#endregion
    public class MergeTwoBinaryTrees
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2) {
        if(t1 == null && t2 == null ) 
            return null;
        
        int val = (t1 == null ? 0 : t1.data) + (t2== null ? 0 : t2.data);
        TreeNode tree = new TreeNode(val);
        
        tree.left =  MergeTrees(t1 == null ? null:t1.left, t2==null?null:t2.left);
        tree.right = MergeTrees(t1 == null ? null:t1.right, t2==null?null:t2.right);
    
        return tree;
        }
    }
}