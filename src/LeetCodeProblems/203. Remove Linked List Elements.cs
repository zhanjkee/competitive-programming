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
	public ListNode RemoveElements(ListNode head, int val)
	{
		if (head == null)
		{
			return null;
		}

		var dummy = new ListNode(0);
		dummy.next = head;
		var currentHead = head;
		ListNode prev = dummy;

		while (currentHead != null)
		{

			if (currentHead.val == val)
			{
				prev.next = currentHead.next;
			}
			else
			{
				prev = currentHead;
			}

			currentHead = currentHead.next;
		}

		return dummy.next;
	}
}