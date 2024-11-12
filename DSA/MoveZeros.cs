public class MoveZerosToEnd
{
    public void MoveZeroes(int[] nums) {

        int left = 0;

        for(int i=0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[left++] = nums[i];
            }
        }

        while(left < nums.Length)
        {
            nums[left++] = 0;
        }

        foreach(int i in nums)
        {
            Console.Write(i+" ");
        }
    }
}