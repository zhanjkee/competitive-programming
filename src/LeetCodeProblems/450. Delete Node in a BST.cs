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
	public TreeNode DeleteNode(TreeNode root, int key)
	{
		if (root == null)
			return root;

		if (root.val == key)
		{
			if (root.left == null)
				return root.right;

			if (root.right == null)
				return root.left;

			TreeNode s = FindSuccessor(root);
			root.val = s.val;
			root.right = DeleteNode(root.right, s.val);
			return root;
		}

		if (root.val < key)
		{
			root.right = DeleteNode(root.right, key);
		}

		if (root.val > key)
		{
			root.left = DeleteNode(root.left, key);
		}

		return root;
	}

	private TreeNode FindSuccessor(TreeNode root)
	{
		TreeNode cur = root.right;
		while (cur != null && cur.left != null)
		{
			cur = cur.left;
		}

		return cur;
	}
}