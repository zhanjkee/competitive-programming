public class Solution
{
	public bool BackspaceCompare(string s, string t)
	{
		return Build(s).Equals(Build(t));
	}

	private string Build(string s)
	{
		var stack = new Stack<char>();
		for (int i = 0; i < s.Length; i++)
		{
			var c = s[i];

			if (c != '#')
			{
				stack.Push(c);
			}
			else
			{
				if (stack.Count != 0) stack.Pop();
			}
		}

		var builder = new StringBuilder();
		while (stack.Count != 0)
		{
			builder.Append(stack.Pop().ToString());
		}

		return builder.ToString();
	}
}