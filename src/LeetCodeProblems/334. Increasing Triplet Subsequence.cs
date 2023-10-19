public class Solution
{
	public bool IncreasingTriplet(int[] nums)
	{

		var n = nums.Length;

		if (n < 3)
		{
			return false;
		}

		int i = int.MaxValue, j = int.MaxValue;

		for (int k = 0; k < n; k++)
		{
			if (nums[k] <= i)
			{
				i = nums[k];
			}
			else if (nums[k] <= j)
			{
				j = nums[k];
			}
			else
			{
				return true;
			}
		}

		return false;
	}
}