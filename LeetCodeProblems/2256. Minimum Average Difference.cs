public class Solution
{
	public int MinimumAverageDifference(int[] nums)
	{
		int result = 0;
		long total = 0;
		long minimumAverageDifference = int.MaxValue;

		for (int i = 0; i < nums.Length; i++)
		{
			total += nums[i];
		}

		long left = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			left += nums[i];
			long right = total - left;

			var averageDifference = Math.Abs((left / (i + 1) - (nums.Length - i == 1 ? 0 : right / (nums.Length - i - 1))));

			if (minimumAverageDifference <= averageDifference)
				continue;

			minimumAverageDifference = averageDifference;
			result = i;
		}

		return result;
	}
}