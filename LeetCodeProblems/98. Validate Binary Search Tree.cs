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
public class Solution
{
	public bool IsValidBST(TreeNode root)
	{
		var stack = new Stack<TreeNode>();
		Nullable<int> prev = null;

		while (stack.Count > 0 || root != null)
		{
			while (root != null)
			{
				stack.Push(root);
				root = root.left;
			}

			root = stack.Pop();

			if (prev != null && root.val <= prev)
			{
				return false;
			}

			prev = root.val;
			root = root.right;
		}

		return true;
	}
}