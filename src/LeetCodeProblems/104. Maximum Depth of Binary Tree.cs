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
	private int ans = 0;

	public int MaxDepth(TreeNode root)
	{
		if (root == null)
		{
			return ans;
		}

		MaxDepth(root, 1);
		return ans;
	}

	public void MaxDepth(TreeNode root, int depth)
	{
		if (root == null)
		{
			return;
		}

		if (root.left == null && root.right == null)
		{
			ans = Math.Max(ans, depth);
		}

		MaxDepth(root.left, depth + 1);
		MaxDepth(root.right, depth + 1);
	}
}