public class FindMaxVowels
{
    public int MaxVowels(string s, int k) {
        int count = 0;
        int max = 0;
        for(int i = 0;i < s.Length;i++)
        {
            if(s[i] == 'a'||s[i] == 'e'||s[i] == 'i'||s[i] == 'o'||s[i] == 'u')
            {
                count++;
                if(count == k)
                {
                    return count;
                }
                continue;
            }
            max = Math.Max(max,count);
            count = 0;

        }
        return count;
    }
}