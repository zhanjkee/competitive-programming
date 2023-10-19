public class DoublyLinkedNode
{
	public int Key { get; set; }
	public int Value { get; set; }
	public DoublyLinkedNode Next { get; set; }
	public DoublyLinkedNode Prev { get; set; }
}

public class LRUCache
{
	private Dictionary<int, DoublyLinkedNode> _cache = new Dictionary<int, DoublyLinkedNode>();
	private int _size;
	private int _capacity;
	private DoublyLinkedNode _head, _tail;

	public LRUCache(int capacity)
	{
		_size = 0;
		_capacity = capacity;
		_head = new DoublyLinkedNode();
		_tail = new DoublyLinkedNode();
		_head.Next = _tail;
		_tail.Prev = _head;
	}

	public int Get(int key)
	{
		if (_cache.TryGetValue(key, out var node))
		{
			MoveToHead(node);
			return node.Value;
		}
		return -1;
	}

	public void Put(int key, int value)
	{
		if (_cache.TryGetValue(key, out var node))
		{
			node.Value = value;
			MoveToHead(node);
		}
		else
		{
			var newNode = new DoublyLinkedNode
			{
				Key = key,
				Value = value
			};

			_cache.Add(key, newNode);
			AddNode(newNode);
			++_size;

			if (_size > _capacity)
			{
				var tail = PopTail();
				_cache.Remove(tail.Key);
				_size--;
			}

		}
	}

	private void AddNode(DoublyLinkedNode node)
	{
		node.Prev = _head;
		node.Next = _head.Next;
		_head.Next.Prev = node;
		_head.Next = node;
	}

	private void RemoveNode(DoublyLinkedNode node)
	{
		DoublyLinkedNode prev = node.Prev;
		DoublyLinkedNode next = node.Next;

		prev.Next = next;
		next.Prev = prev;
	}

	private void MoveToHead(DoublyLinkedNode node)
	{
		RemoveNode(node);
		AddNode(node);
	}

	private DoublyLinkedNode PopTail()
	{
		DoublyLinkedNode res = _tail.Prev;
		RemoveNode(res);
		return res;
	}
}