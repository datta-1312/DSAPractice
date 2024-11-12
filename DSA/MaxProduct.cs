public class MaxProductSolution {
    public int MaxProduct(int[] nums) {
        if(nums==null || nums.Length==1) return nums[0];
        int maxSoFar = nums[0]<0 ? 1 :int.MinValue;
        int previousMax = int.MinValue;
        int previous = int.MinValue;

        for(int i=0; i<nums.Length; i++)
        {
            previous = maxSoFar;
            maxSoFar = Math.Max(nums[i],maxSoFar*nums[i]);
            if(previous>maxSoFar)
            {
                previousMax = previous;
            }
        }

        return Math.Max(maxSoFar,previousMax);
    }
}