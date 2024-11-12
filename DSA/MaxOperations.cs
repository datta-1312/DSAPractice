public class MaxOperation
{
    public int MaxOperations(int[] nums, int k) {
        int left = 0;
        int right = nums.Length - 1;
        int count = 0;

        while(left < right)
        {
            if(nums[left] + nums[right] == k)
            {
                count++;
                left++;
                right--;
                continue;
            }
                
            if(nums[left] >= k)
            {
                left++;
            }

            if(nums[right] >= k)
            {
                right--;
            }

            if(nums[left] <= k)
            {
                right--;
            }

            if(nums[right] <= k)
            {
                left++;
            }
        }

        return count;
    }
}