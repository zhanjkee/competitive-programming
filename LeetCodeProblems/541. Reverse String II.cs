public class Solution
{
	public string ReverseStr(string s, int k)
	{
		char[] characters = s.ToCharArray();
		int length = characters.Length;

		for (int start = 0; start < length; start += 2 * k)
		{
			int left = start;
			int right = Math.Min(start + k - 1, length - 1);

			while (left < right)
			{
				char temp = characters[left];
				characters[left] = characters[right];
				characters[right] = temp;
				left++;
				right--;
			}
		}

		return new string(characters);
	}
}