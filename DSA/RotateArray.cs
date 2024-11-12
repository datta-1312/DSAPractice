public class RotateArray
{
    public void Rotate(int[] nums, int k) 
    {
        if(k == 0) return;
        List<int> lst = new List<int>(nums);
        for(int i = 0; i < k; i++)
        {
            int lastValue = lst[lst.Count-1];
            lst.Remove(lst[lst.Count-1]);
            lst.Insert(0,lastValue);
        }
        nums = lst.ToArray();


        // List<int> lst = new List<int>();
        // for(int i = 0; i <= k; i++)
        // {
        //     lst.AddRange(nums.ToList());
        // }
        // if(nums.Length %2 != 0 && k % 2 != 0)
        // {
        //     k = k+1;
        // }
        // for(int j = k, i=0; j < lst.Count;)
        // {
        //     if(i < nums.Length)
        //     {
        //         nums[i++] = lst[j++];
        //         continue;
        //     }
        //     break;     
        // }
        //lst = null;
    }
}