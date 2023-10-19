public class Solution
{
	public int MaxArea(int[] height)
	{
		int left = 0;
		int right = height.Length - 1;
		int area = 0;

		while (left < right)
		{
			// Calculating max area.
			area = Math.Max(area,
						   Math.Min(height[left], height[right]) * (right - left));

			if (height[left] < height[right])
			{
				left++;
			}
			else
			{
				right--;
			}
		}

		return area;
	}
}