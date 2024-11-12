using System.Text;

public class MergeAlternate
{
    public string MergeAlternately(string word1, string word2) {
        StringBuilder sb = new StringBuilder();
        int firstStringLength = word1.Length;
        int secondStringLength = word2.Length;
        
        int i = 0,j = 0;
        //bool flag = false;
        while(i < firstStringLength && j < secondStringLength)
        {
            sb.Append(word1[i++]);
            sb.Append(word2[j++]);
            // if(!flag)
            // {
            //     flag= true;
            //     sb.Append(word1[i++]);
            //     continue;
            // }
            // sb.Append(word2[j++]);
            // flag= false;
        }
        while(i < firstStringLength)
        {
            sb.Append(word1[i++]);
        }
        while(j < firstStringLength)
        {
            sb.Append(word2[j++]);
        }

        return sb.ToString();
    }
}