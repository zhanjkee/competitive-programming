public class Solution
{
	public int MinSubArrayLen(int target, int[] nums)
	{
		int minLength = int.MaxValue;
		int left = 0;
		int currentSum = 0;

		for (int right = 0; right < nums.Length; right++)
		{
			currentSum += nums[right];

			if (currentSum >= target)
			{
				var minL = right - left + 1;
				minLength = minL < minLength ? minL : minLength;
				left = right;
				currentSum -= nums[left];
			}
		}

		return minLength;
	}
}