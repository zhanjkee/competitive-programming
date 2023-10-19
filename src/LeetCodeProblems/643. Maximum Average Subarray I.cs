public class Solution
{
	public double FindMaxAverage(int[] nums, int k)
	{
		double sum = 0;

		for (int i = 0; i < k; i++)
		{
			sum += nums[i];
		}

		double result = sum;

		for (int i = k; i < nums.Length; i++)
		{
			sum += nums[i] - nums[i - k];
			result = Math.Max(sum, result);
		}

		return result / k;
	}
}