public class Solution
{
	public int PivotIndex(int[] nums)
	{
		int numsLength = nums.Length;

		int leftSum = 0;
		int rightSum = 0;

		for (int i = 0; i < numsLength; i++)
		{
			rightSum += nums[i];
		}

		for (int i = 0; i < numsLength; i++)
		{
			rightSum -= nums[i];

			if (rightSum == leftSum)
			{
				return i;
			}

			leftSum += nums[i];
		}

		return -1;
	}
}