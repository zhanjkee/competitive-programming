public class Solution
{
	public bool ContainsNearbyDuplicate(int[] nums, int k)
	{
		var limit = 0;
		var dict = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{
			var n = nums[i];

			if (dict.ContainsKey(n))
			{
				return true;
			}

			dict.TryAdd(n, n);

			if (dict.Count > k)
			{
				dict.Remove(nums[i - k]);
			}
		}

		return false;
	}
}