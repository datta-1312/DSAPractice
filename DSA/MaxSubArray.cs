public class KadanesAlgo
{
    public void MaxSubArray(int[] nums)
    {
        int l = 0, r = 1, maxSum = 0;

        while(r < nums.Length)
        {
            int currentSum = nums[l] + nums[r];
            if(currentSum > maxSum)
            {
                maxSum = currentSum;
                r++;
                continue;
            }
            l = r;
            r++;
        }

        Console.WriteLine($"Max sum {maxSum}");
    }
}