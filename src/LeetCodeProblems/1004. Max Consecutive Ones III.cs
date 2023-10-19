public class Solution
{
	public int LongestOnes(int[] nums, int k)
	{
		int left = 0, right;
		for (right = 0; right < nums.Length; right++)
		{
			if (nums[right] == 0)
				k--;

			if (k >= 0) continue;
			k += 1 - nums[left];
			left++;
		}

		return right - left;
	}
}