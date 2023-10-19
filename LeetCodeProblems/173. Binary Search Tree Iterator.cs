/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class BSTIterator
{
    private Stack<TreeNode> _stack;

    public BSTIterator(TreeNode root)
	{
        _stack = new Stack<TreeNode>();
        LeftMostInOrder(root);
    }

    public int Next()
	{
        var node = _stack.Pop();
        
        if (node.right != null)
		{
            LeftMostInOrder(node.right);
        }

        return node.val;
    }

    public bool HasNext()
	{
        return _stack.Count > 0;
    }

    private void LeftMostInOrder(TreeNode root)
	{
        while (root != null)
		{
            _stack.Push(root);
            root = root.left;
        }
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */