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
	public IList<int> PostorderTraversal(TreeNode root)
	{
		var result = new List<int>();

		if (root == null)
		{
			return result;
		}

		PostorderTraversal(root, result);

		return result;
	}

	private void PostorderTraversal(TreeNode root, IList<int> result)
	{
		if (root == null)
			return;

		if (root.left != null)
		{
			PostorderTraversal(root.left, result);
		}

		if (root.right != null)
		{
			PostorderTraversal(root.right, result);
		}

		result.Add(root.val);
	}
}