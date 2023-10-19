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
	public TreeNode InsertIntoBST(TreeNode root, int val)
	{
		if (root == null)
		{
			root = new TreeNode(val, null, null);
			return root;
		}

		if (root.val > val)
		{
			if (root.left != null)
			{
				InsertIntoBST(root.left, val);
			}
			else
			{
				root.left = new TreeNode(val, null, null);
			}
		}
		else
		{
			if (root.right != null)
			{
				InsertIntoBST(root.right, val);
			}
			else
			{
				root.right = new TreeNode(val, null, null);
			}
		}

		return root;
	}
}