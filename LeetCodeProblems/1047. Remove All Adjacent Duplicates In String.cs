public class Solution
{
	public string RemoveDuplicates(string s)
	{
		var stack = new Stack<char>();
		for (int i = 0; i < s.Length; i++)
		{
			var c = s[i];
			if (stack.Count != 0 && stack.Peek() == c)
			{
				stack.Pop();
			}
			else
			{
				stack.Push(c);
			}
		}

		var arr = new char[stack.Count];
		int index = 0;

		while (stack.Count != 0)
		{
			arr[index] = stack.Pop();
			index++;
		}

		Array.Reverse(arr);
		return new string(arr);
	}
}