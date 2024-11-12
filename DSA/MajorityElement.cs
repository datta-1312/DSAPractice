public class Majority {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int majorityElement = 0;
        foreach(int item in nums)
        {
            if(!(dict.ContainsKey(item)))
            {
                dict.Add(item,1);
                continue;
            }
            dict[item]++;
        }
        foreach(int item in dict.Keys)
        {
            if(majorityElement < dict[item])
            {
                majorityElement = item;
            }
        }

        return majorityElement;
    }
}