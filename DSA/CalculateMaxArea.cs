public class MaxAreaCalculate
{
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length-1;
        int max = 0;
        while(left < right)
        {
            int area = 0;
            if(height[left] < height[right])
            {
                area = height[left] * (right-left);
                left++;
                //continue;
            }
            else if(height[left] == height[right])
            {
                area = height[right] * (right-left);
                left++;
                right--;
                //continue;
            }
            else
            {
                area = height[right] * (right - left);
                right--;
            }

            if(area > max)
            {
                max = area;
            }
        }

        return max;
    }
}