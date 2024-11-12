public class FindingPivot
{
    public int PivotIndex(int[] nums) 
    {
        int maxSum = nums.Sum();
        int prefixSum = 0;
         for(int i = 0; i < nums.Length; i++)
         {
            prefixSum+=nums[i];
            if(maxSum - prefixSum == prefixSum-nums[i])
            {
                return i;
            }
         }
        return -1;
    }
}