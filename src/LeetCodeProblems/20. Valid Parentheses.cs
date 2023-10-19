public class Solution
{
	private readonly Dictionary<char, char> _matching = new Dictionary<char, char>(){
		{'(', ')'},
		{'{', '}'},
		{'[', ']'},
	};

	public bool IsValid(string s)
	{
		if (string.IsNullOrEmpty(s) || s.Length % 2 != 0)
		{
			return false;
		}

		var stack = new Stack<char>();
		
		for (int i = 0; i < s.Length; i++)
		{
			char c = s[i];
			if (_matching.ContainsKey(c))
			{
				stack.Push(c);
			}
			else
			{
				if (stack.Count == 0)
				{
					return false;
				}

				char previousOpening = stack.Pop();
				if (_matching[previousOpening] != c)
				{
					return false;
				}
			}
		}

		return stack.Count == 0;
	}
}