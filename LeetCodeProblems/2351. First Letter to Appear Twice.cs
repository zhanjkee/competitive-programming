public class Solution
{
	public char RepeatedCharacter(string s)
	{
		var dict = new Dictionary<char, int>();
		for (int i = 0; i < s.Length; i++)
		{
			var c = s[i];
			if (dict.ContainsKey(c))
				return c;

			dict.TryAdd(c, i);
		}

		return ' ';
	}
}