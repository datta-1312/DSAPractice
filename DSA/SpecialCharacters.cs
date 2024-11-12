public class SpecialCharacters
{
    public int NumberOfSpecialChars(string word) 
    {
        HashSet<char> uniqueChars = new HashSet<char>(word);
        int count = 0;
        foreach(char letter in word)
        {
            if(uniqueChars.Contains((char)(letter+32)) || uniqueChars.Contains((char)(letter-32)))
            {
                count++;
            }
        }
        // List<char> lst = new HashSet<char>(word).OrderBy(x=>x).ToList();
        // int count = 0;
        // int index = 0;
        // for(int i = 0; i < lst.Count; i++)
        // {
        //     if(lst[i] >= 97)
        //     {
        //         index = i;
        //         break;
        //     }
        // }
        // if(index == 0)
        // {
        //     return 0;
        // }

        // for(int i = 0; i < lst.Count;)
        // {
        //     if(index == lst.Count)
        //     {
        //         break;
        //     }
        //     if((lst[index] - lst[i]) == 32)
        //     {
        //         i++;
        //         index++;
        //         count++;
        //         continue;
        //     }
        //     if((lst[index] - lst[i]) < 32)
        //     {
        //         index++;
        //     }
        // }
        return count;
    }
}