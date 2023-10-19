public class Solution
{
	private static readonly HashSet<char> Vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

	public int MaxVowels(string s, int k)
	{
		int left = 0;
		int counter = 0;
		int maximumNumberOfVowel = 0;

		for (int right = 0; right < s.Length; right++)
		{
			char letterToLookup = s[right];
			if (Vowels.Contains(letterToLookup))
			{
				counter++;
			}

			if (k < right - left + 1)
			{
				letterToLookup = s[left];
				if (Vowels.Contains(letterToLookup))
				{
					counter--;
				}
				left++;
			}
			maximumNumberOfVowel = Math.Max(maximumNumberOfVowel, counter);
		}

		return maximumNumberOfVowel;
	}
}