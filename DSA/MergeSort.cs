
public class MergeSortClass
{
    public void Sort(int[] nums, int left , int right)
    {
        if(left>=right) return;
        int mid = left+(right-left)/2;
        Sort(nums,left,mid);
        Sort(nums, mid+1, right);

        Merge(nums, left, mid, right);
    }

    private void Merge(int[] nums, int left, int mid, int right)
    {
        int[] temp = new int[right - left+1];
        int i = left,j = mid+1,k = 0;

        while(i <= mid && j<= right)
        {
            if(nums[i] <= nums[j])
            {
                temp[k++] = nums[i++];
                continue;
            }
            temp[k++] = nums[j++];
        }

        while(i<=mid)
        {
            temp[k++] = nums[i++];
        }

        while(j<=right)
        {
            temp[k++] = nums[j++];
        }

        int y = 0;
        for(int z= left;z<=right;z++)
        {
            nums[z] = temp[y++];
        }
    }
}