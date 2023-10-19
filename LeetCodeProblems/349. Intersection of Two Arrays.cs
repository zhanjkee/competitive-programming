public class Solution
{
	public int[] Intersection(int[] nums1, int[] nums2)
	{
		var intersection = new HashSet<int>();
		var dict = new Dictionary<int, int>();

		for (int i = 0; i < nums1.Length; i++)
		{
			dict.TryAdd(nums1[i], nums1[i]);
		}

		for (int i = 0; i < nums2.Length; i++)
		{
			if (dict.ContainsKey(nums2[i]))
			{
				intersection.Add(nums2[i]);
			}
		}

		return intersection.ToArray();
	}
}