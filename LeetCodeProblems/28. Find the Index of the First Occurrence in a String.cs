public class Solution
{
	public int StrStr(string haystack, string needle)
	{
		int haystackLength = haystack.Length;
		int needleLength = needle.Length;

		if (needleLength == 0)
		{
			return 0;
		}

		char firstLetterOfNeedle = needle[0];

		for (int i = 0; i <= haystackLength - needleLength; i++)
		{
			if (haystack[i] == firstLetterOfNeedle &&
				IsStringEquals(haystack.Substring(i, needleLength), needle))
			{
				return i;
			}
		}

		return -1;
	}

	private static bool IsStringEquals(string left, string right)
	{
		return left.Equals(right);
	}
}