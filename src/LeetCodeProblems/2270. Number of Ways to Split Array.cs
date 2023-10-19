public class Solution
{
	public int WaysToSplitArray(int[] nums)
	{
		long[] prefix = new long[nums.Length];
		prefix[0] = nums[0];

		for (int i = 1; i < nums.Length; i++)
		{
			prefix[i] = prefix[i - 1] + nums[i];
		}

		int ans = 0;

		for (int i = 0; i < nums.Length - 1; i++)
		{
			var left = prefix[i];
			var right = prefix[prefix.Length - 1] - prefix[i];

			if (left >= right)
				ans++;
		}

		return ans;
	}
}