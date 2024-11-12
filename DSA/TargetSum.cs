public class TargetSum {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> lst = [];
        int left = 0;
        int right = nums.Length;
        while(left < right)
        {
            int difference = target - nums[left];
            if(lst.ContainsKey(difference))
            {
                return [lst[difference],left];
            }
            lst[nums[left]] = left;
            left++;
        }
        return [];
    }
}