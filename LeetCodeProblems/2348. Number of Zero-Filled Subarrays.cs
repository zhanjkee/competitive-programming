public class Solution
{
	public long ZeroFilledSubarray(int[] nums)
	{
		long ans = 0, subArray = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] == 0)
			{
				subArray++;
			}
			else
			{
				subArray = 0;
			}

			ans += subArray;
		}

		return ans;
	}
}