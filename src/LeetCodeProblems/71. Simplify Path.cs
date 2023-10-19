public class Solution
{
	public string SimplifyPath(string path)
	{
		var stack = new Stack<string>();
		var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
		stack.Push("");
		
		foreach (var dir in parts)
		{
			switch (dir)
			{
				case ".":
					break;
				case "..":
					if (stack.Count > 0) stack.Pop();
					break;
				default:
					stack.Push(dir);
					break;
			}
		}

		var sbResult = new StringBuilder();
		while (stack.Count > 0)
		{
			var dir = stack.Pop();
			sbResult.Insert(0, dir);

			if (dir != "")
			{
				sbResult.Insert(0, '/');
			}
		}

		if (sbResult.Length == 0)
		{
			return "/";
		}

		return sbResult.ToString();
	}
}