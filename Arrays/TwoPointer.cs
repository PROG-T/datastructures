public class TwoPointer
{
	public TwoPointer()
	{
	}
	public int MaxArea(int[] heights) {
		int maxArea = 0;
		int leftIndex = 0;
		int rightIndex = heights - 1;

		while (leftIndex < rightIndex) {
			int width = rightIndex - leftIndex;
			int height = Math.Min(heights[leftIndex], heights[rightIndex]); 
			int area  = width * height;
			maxArea  = Math.Max(maxArea, area);

			if (heights[leftIndex]< heights[rightIndex])
			{
				leftIndex++;
			}
			else 
			{
				rightIndex--;
			}
		}
		return maxArea;
	}
}