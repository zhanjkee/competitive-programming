public class KthLargest
{
	private Node insertNode(Node root, int num)
	{
		if (root == null)
		{
			return new Node(num, 1);
		}
		if (root.val <= num)
		{
			root.right = insertNode(root.right, num);
		}
		else
		{
			root.left = insertNode(root.left, num);
		}
		root.cnt++;
		return root;
	}

	public int searchKth(Node root, int k)
	{
		int m = root.right != null ? root.right.cnt : 0;

		if (k == m + 1)
		{
			return root.val;
		}

		if (k <= m)
		{
			return searchKth(root.right, k);
		}
		else
		{
			return searchKth(root.left, k - m - 1);
		}
	}

	private Node root;
	private int tempK;

	public KthLargest(int k, int[] nums)
	{
		root = null;
		for (int i = 0; i < nums.Length; ++i)
		{
			root = insertNode(root, nums[i]);
		}
		tempK = k;
	}

	public int Add(int val)
	{
		root = insertNode(root, val);
		return searchKth(root, tempK);
	}
}

public class Node
{
	public int val;
	public int cnt;
	public Node left;
	public Node right;

	public Node(int v, int c)
	{
		val = v;
		cnt = c;
	}
}
/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */