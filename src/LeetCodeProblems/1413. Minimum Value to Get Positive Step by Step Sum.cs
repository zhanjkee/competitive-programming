public class Solution
{
	public int MinStartValue(int[] nums)
	{
		int minVal = 0;
		int total = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			total += nums[i];
			minVal = Math.Min(total, minVal);
		}

		return -minVal + 1;
	}
}