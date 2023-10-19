/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution
{
	public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
	{
		int rootVal = root.val;
		int pVal = p.val;
		int qVal = q.val;

		if (pVal > rootVal && qVal > rootVal)
		{
			return LowestCommonAncestor(root.right, p, q);
		}
		else if (pVal < rootVal && qVal < rootVal)
		{
			return LowestCommonAncestor(root.left, p, q);
		}
		else
		{
			return root;
		}
	}
}