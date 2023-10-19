public class Solution
{
	public bool CarPooling(int[][] trips, int capacity)
	{
		int size = 0;

		for (int i = 0; i < trips.Length; i++)
		{
			size = Math.Max(size, trips[i][2]);
		}

		int[] arr = new int[size + 1];
		
		for (int i = 0; i < trips.Length; i++)
		{
			int value = trips[i][0], from = trips[i][1], to = trips[i][2];

			arr[from] += value;
			arr[to] -= value;
		}

		int curr = 0;
		
		for (int i = 0; i < arr.Length; i++)
		{
			curr += arr[i];

			if (curr > capacity)
				return false;
		}

		return true;
	}
}