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
	private int Height(TreeNode root)
	{
		if (root == null)
		{
			return -1;
		}

		return 1 + Math.Max(Height(root.left), Height(root.right));
	}

	public bool IsBalanced(TreeNode root)
	{
		if (root == null)
		{
			return true;
		}

		return Math.Abs(Height(root.left) - Height(root.right)) < 2
			&& IsBalanced(root.left)
			&& IsBalanced(root.right);
	}
}