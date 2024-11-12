public class CountChars
{
    public int CountCharacters(string[] words, string chars) {

        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(char item in chars)
        {
            if(!dict.ContainsKey(item))
            {
                dict.Add(item,1);
                continue;
            }
            dict[item]++;
        }

        Dictionary<char,int> cache;
        int count = 0;
        foreach(string word in words)
        {
            cache = new Dictionary<char,int>(dict);
            int dummy = 0;
            foreach(char character in word)
            {
                if(cache.ContainsKey(character) && cache[character]>=1)
                {
                    cache[character]--;
                    dummy++;
                    count++;
                    continue;
                }
                count -= dummy;
                break;
            }
        }
        return count;
    }
}