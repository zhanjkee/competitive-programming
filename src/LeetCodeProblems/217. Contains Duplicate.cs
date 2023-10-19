public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		var dict = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			var n = nums[i];
			if (dict.ContainsKey(n))
				return true;

			dict.TryAdd(n, n);
		}

		return false;
	}
}