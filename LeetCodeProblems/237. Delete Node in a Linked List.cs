/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
	public void DeleteNode(ListNode node)
	{
		if (node == null)
			return;

		var nextNode = node.next;
		node.val = nextNode.val;
		node.next = nextNode.next;
		nextNode = null;
	}
}