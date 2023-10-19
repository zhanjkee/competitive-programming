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
	public ListNode ReverseBetween(ListNode head, int left, int right)
	{
		if (head == null)
		{
			return null;
		}

		var current = head;
		ListNode prev = null;

		while (left > 1)
		{
			prev = current;
			current = current.next;
			left--;
			right--;
		}

		var con = prev;
		var tail = current;
		ListNode third = null;

		while (right > 0)
		{
			third = current.next;
			current.next = prev;
			prev = current;
			current = third;
			right--;
		}

		if (con != null)
		{
			con.next = prev;
		}
		else
		{
			head = prev;
		}

		tail.next = current;

		return head;
	}
}