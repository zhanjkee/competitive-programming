/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
	private ListNode frontPointer;

	public bool IsPalindrome(ListNode head)
	{
		frontPointer = head;
		return RecursivelyCheck(head);
	}

	private bool RecursivelyCheck(ListNode node)
	{
		if (node != null)
		{
			if (!RecursivelyCheck(node.next)) return false;
			if (frontPointer.val != node.val) return false;
			frontPointer = frontPointer.next;
		}

		return true;
	}
}