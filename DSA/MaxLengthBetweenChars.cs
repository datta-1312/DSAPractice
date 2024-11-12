using System.ComponentModel;

public class MaxLengthBetweenChars
{
    public int MaxLengthBetweenEqualCharacters(string s) {
        bool flag = false;
        Dictionary<char,int> dict = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++)
        {
            if(!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i],i+1);
                continue;
            }
            flag = true;
            dict[s[i]]=(i - dict[s[i]]);
        }
        if(!flag) return -1;
        return dict.Values.Max(x=>x);
    }
}