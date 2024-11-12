using System.Text;

class LongestCommonPrefix
{
    public string LongestCommonPrefixFunction(string[] strs) 
    {
        if(strs.Length == 1) return strs[0];

        if(strs.Length == 1) return strs[0];
        StringBuilder prefix = new StringBuilder();
        prefix.Append(strs[0]);
        for(int i = 1; i < strs.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < strs[i].Length; j++)
            {
                if(j < prefix.Length && prefix.ToString()[j] == strs[i][j])
                {
                    count++;
                    continue;
                }
                break;
            }
            if(prefix.Length > count)
            {
                prefix.Clear();
                prefix.Append(strs[i].Substring(0,count));
            }
        }
        return prefix.ToString();

        // StringBuilder prefix = new StringBuilder();
        // string[] result = new string[200];
        // result[0] = strs[0];
        // for(int i=1,j=0;i<strs.Length;i++,j++)
        // {
        //     result[i] = GetPrefix(strs[i-1],strs[i]);
        //     if(string.IsNullOrEmpty(result[j]))
        //     {
        //         return string.Empty;
        //     }

        //     if(result[j].Length < result[i].Length)
        //     {
        //         prefix.Clear();
        //         prefix.Append(result[j]);
        //     }
        //     else
        //     {
        //         prefix.Clear();
        //         prefix.Append(result[i]);
        //     }
        // }
        //eturn result.Min(x=>x.Length).ToString();
    }

    private string GetPrefix(string previous, string next)
    {
        int maxLength = 0;
        if(previous.Length < next.Length)
        {
            maxLength = previous.Length;
        }
        else
        {
            maxLength = next.Length;
        }
        int leftPtr = 0;
        StringBuilder prefix = new StringBuilder(200);

        while(leftPtr < maxLength)
        {
            if(previous[leftPtr]!=next[leftPtr])
            {
                return prefix.ToString();
            }
            prefix.Append(previous[leftPtr]);
            leftPtr++;
        }
        return prefix.ToString();
    }
}