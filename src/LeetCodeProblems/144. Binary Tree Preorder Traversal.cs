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
	public IList<int> PreorderTraversal(TreeNode root)
	{
		var result = new List<int>();

		if (root == null)
		{
			return result;
		}

		PreOrderTraversal(root, result);

		return result;
	}

	private void PreOrderTraversal(TreeNode root, IList<int> result)
	{
		if (root == null)
		{
			return;
		}

		result.Add(root.val);

		if (root.left != null)
		{
			PreOrderTraversal(root.left, result);
		}

		if (root.right != null)
		{
			PreOrderTraversal(root.right, result);
		}
	}
}