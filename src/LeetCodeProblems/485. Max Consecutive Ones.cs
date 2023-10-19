public class Solution
{
	public int FindMaxConsecutiveOnes(int[] nums)
	{
		int count = 0;
		int max = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 1)
			{
				count++;
			}
			else
			{
				count = 0;
			}

			max = Math.Max(max, count);
		}

		return max;
	}
}