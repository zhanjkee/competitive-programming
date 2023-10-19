public class Solution
{
	public bool CheckIfPangram(string sentence)
	{
		var dict = new Dictionary<char, int>();
		for (int i = 0; i < sentence.Length; i++)
		{
			var c = sentence[i];
			dict.TryAdd(c, i);
		}
		return dict.Count == 26;
	}
}