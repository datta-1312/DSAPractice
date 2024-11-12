using System.Diagnostics;

public class AdaptiveBubbleSort
{
    public void BubbleSort(int[] nums)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        for (int i = 0; i < nums.Length; i++)
        {
            int flag = 0;
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                if(nums[j] > nums[j+1])
                {
                    flag++;
                    int temp = nums[j];
                    nums[j] = nums[j+1];
                    nums[j + 1] = temp;
                }
            }
            if(flag == 0)break;
        }
        stopwatch.Stop();
        Console.WriteLine($"Time taken to perform bubble sort is {stopwatch.ElapsedMilliseconds} ms");
    }
}