public class Solution
{
	public int LengthOfLastWord(string s)
	{
		int length = 0;
		bool letterFound = false;

		for (int i = s.Length - 1; i >= 0; i--)
		{
			if (s[i] == ' ' && !letterFound)
			{
				continue;
			}

			letterFound = true;

			if (s[i] == ' ')
			{
				break;
			}

			length++;
		}

		return length;
	}
}