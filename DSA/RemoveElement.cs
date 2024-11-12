public class RemoveElementInArray {
    public int RemoveElement(int[] nums, int val) {
        List<int> lst = new List<int>();

        foreach(int num in nums)
        {
            if(num != val)
            {
                lst.Add(num);
            }
        }
        int[] expectedNums = new int[nums.Length];

        for(int i = 0; i < nums.Length ; i++)
        {
            if(i < lst.Count)
            {
                expectedNums[i] = lst[i];
                continue;
            }
            expectedNums[i] = '_';
        }

        return lst.Count;
    }
}