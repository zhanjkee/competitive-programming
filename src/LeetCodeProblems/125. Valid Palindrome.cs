public class Solution
{
	public bool IsPalindrome(string s)
	{
		string cleanedString = CleanString(s);
		int left = 0;
		int right = cleanedString.Length - 1;

		while (left < right)
		{
			if (cleanedString[left] != cleanedString[right])
			{
				return false;
			}

			left++;
			right--;
		}

		return true;
	}

	private string CleanString(string s)
	{
		char[] charArray = s.ToLower().ToCharArray();

		for (int i = 0; i < charArray.Length; i++)
		{
			if (!char.IsLetterOrDigit(charArray[i]))
			{
				charArray[i] = ' ';
			}
		}

		return new string(charArray).Replace(" ", "");
	}
}