/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution
{
	public ListNode DetectCycle(ListNode head)
	{
		if (head == null)
		{
			return null;
		}

		var slow = head;
		var fast = head;

		while (fast != null && fast.next != null)
		{
			var prev = fast.next;
			fast = fast.next.next;
			slow = slow.next;

			if (fast == slow)
			{
				fast = head;

				while (fast != slow)
				{
					fast = fast.next;
					slow = slow.next;
				}

				return slow;
			}
		}

		return null;
	}
}