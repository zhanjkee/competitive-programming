public class Solution 
{
	public int DominantIndex(int[] nums)
	{
		if (nums == null || nums.Length == 0)
		{
			return -1;
		}

		int maxValue = nums[0];
		int maxValueIndex = 0;

		for (int i = 1; i < nums.Length; i++)
		{
			if (nums[i] > maxValue)
			{
				maxValue = nums[i];
				maxValueIndex = i;
			}
		}

		for (int i = 0; i < nums.Length; i++)
		{
			if (i != maxValueIndex && nums[i] * 2 > maxValue)
			{
				return -1;
			}
		}

		return maxValueIndex;
	}
}