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
	public IList<IList<int>> LevelOrder(TreeNode root)
	{
		var result = new List<IList<int>>();
		var queue = new Queue<TreeNode>();

		if (root != null)
		{
			queue.Enqueue(root);
		}

		while (queue.Count != 0)
		{
			var size = queue.Count;
			var values = new List<int>();

			for (int i = 0; i < size; i++)
			{
				var item = queue.Dequeue();
				values.Add(item.val);

				if (item.left != null)
				{
					queue.Enqueue(item.left);
				}

				if (item.right != null)
				{
					queue.Enqueue(item.right);
				}
			}

			result.Add(values);
		}

		return result;
	}
}