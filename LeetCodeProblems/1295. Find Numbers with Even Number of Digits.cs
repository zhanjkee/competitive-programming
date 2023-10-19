public class Solution
{
	public int FindNumbers(int[] nums)
	{
		int count = 0;

		for (int i = 0; i < nums.Length; i++)
		{

			if (NumDigits(nums[i]) % 2 == 0)
			{
				count++;
			}
		}

		return count;
	}

	public int NumDigits(int n)
	{
		if (n > 0)
			return 1 + NumDigits(n / 10);

		return 0;
	}
}