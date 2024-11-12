using System.Text;
public class OptimalPartition
{
    public int PartitionString(string s) {
        List<StringBuilder> lst = new();
        StringBuilder subString = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(subString.ToString().Contains(s[i]))
            {
                lst.Add(subString);
                subString.Clear();
                i--;
                continue;
            }
            subString.Append(s[i]);
        }

        return lst.Count + 1;
    }
}