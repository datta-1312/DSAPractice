using System.Text;

public class MakeEqual
{
    public bool IsMakeEqual(string[] words) {
        int worldLength = words[0].Length-1;
        // if(words.Where(word=>word.Length == worldLength))
        //     return false;

        StringBuilder sb = new StringBuilder();
        foreach(string word in words)
        {
            sb.Append(word);
        }
        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(char character in sb.ToString())
        {
            if(!dict.ContainsKey(character))
            {
                dict.Add(character,1);
                continue;
            }
            dict[character]++;
        }
        int previousFrequency = dict.Values.ToList().FirstOrDefault();
        foreach(char character in dict.Keys)
        {
            if(dict[character]==previousFrequency)
            {
                previousFrequency = dict[character];
                continue;
            }
            return false;
        }
        return true;
    }
}