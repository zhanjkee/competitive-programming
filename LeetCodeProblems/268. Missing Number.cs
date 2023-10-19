public class Solution
{
	public int MissingNumber(int[] nums)
	{
		HashSet<int> numSet = new HashSet<int>(nums.Length);

		for (int i = 0; i < nums.Length; i++)
		{
			numSet.Add(nums[i]);
		}

		for (int i = 0; i < nums.Length + 1; i++)
		{
			if (!numSet.Contains(i))
			{
				return i;
			}
		}

		return -1;
	}
}