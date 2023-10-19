public class SingleListNode
{
	public int val;
	public SingleListNode next;

	public SingleListNode(int val)
	{
		this.val = val;
	}
}

public class MyLinkedList
{
	private SingleListNode _head;

	public MyLinkedList()
	{
		_head = null;
	}

	public int Get(int index)
	{
		var current = GetNode(index);
		return current == null ? -1 : current.val;
	}

	public void AddAtHead(int val)
	{
		var cur = new SingleListNode(val);
		cur.next = _head;
		_head = cur;
	}

	public void AddAtTail(int val)
	{
		if (_head == null)
		{
			AddAtHead(val);
			return;
		}

		var current = new SingleListNode(val);
		var previous = GetTail();
		previous.next = current;
	}

	public void AddAtIndex(int index, int val)
	{
		if (index == 0)
		{
			AddAtHead(val);
			return;
		}

		var previous = GetNode(index - 1);

		if (previous == null)
			return;

		var next = previous.next;
		var current = new SingleListNode(val);
		current.next = next;
		previous.next = current;
	}

	public void DeleteAtIndex(int index)
	{
		var current = GetNode(index);

		if (current == null)
			return;

		var next = current.next;

		if (index == 0)
			_head = next;
		else
		{
			var previous = GetNode(index - 1);

			if (previous == null)
				return;

			previous.next = next;
		}
	}

	private SingleListNode GetNode(int index)
	{
		var current = _head;

		for (int i = 0; i < index && current != null; ++i)
		{
			current = current.next;
		}

		return current;
	}

	private SingleListNode GetTail()
	{
		var current = _head;

		while (current != null && current.next != null)
		{
			current = current.next;
		}

		return current;
	}
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */