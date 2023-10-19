public class Solution
{
	public int SingleNumber(int[] nums)
	{
		var dict = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{

			var val = 0;
			if (dict.TryGetValue(nums[i], out val))
			{
				dict[nums[i]] = val + 1;
			}
			else
			{
				dict.Add(nums[i], 1);
			}
		}

		foreach (var item in dict)
		{
			if (item.Value == 1)
			{
				return item.Key;
			}
		}

		return -1;
	}
}