using System.Text;

public class FullyJustify {
    public IList<string> FullJustify(string[] words, int maxWidth) {

        int i = 0, numOfWords=0;
        List<int> wordPerLineList = new List<int>();

        foreach(string word in words)
        {
            i += word.Length+1;
            numOfWords++;
            if(i > maxWidth)
            {
                i -= word.Length-1;
                numOfWords--;
                wordPerLineList.Add(numOfWords);
                numOfWords = 0;
                i=word.Length+1;
                numOfWords++;
                continue;
            }
            if(i == maxWidth)
            {
                wordPerLineList.Add(numOfWords);
                numOfWords = 0;
                i=0;
                continue;
            }
        }
        wordPerLineList.Add(numOfWords);
        List<string> output = new List<string>();
        int upperIndex = 0;
        int lowerIndex = 0;
        for(int y = 0; y < wordPerLineList.Count; y++)
        {
            upperIndex += wordPerLineList[y];
            output.Add(CombineWord(words.Skip(lowerIndex).Take(upperIndex-lowerIndex).ToArray(),wordPerLineList[y],maxWidth));
            lowerIndex = upperIndex;
        }
        return output;
    }

    private string CombineWord(string[] words, int numberOfWords, int maxWidth)
    {
        StringBuilder sb = new StringBuilder();
        int nextIndexToInsert = 0;
        for(int i = 0; i < maxWidth; i++)
        {
            sb.Append(' ');
        }

        int remainingGap = maxWidth - (words[numberOfWords-1].Length + words[0].Length);
     
        sb.Insert(0,words[0]);
        //Replace(string oldValue, string? newValue, int startIndex, int count);
        sb.Insert(maxWidth-words[numberOfWords-1].Length,words[numberOfWords-1]);

        // sb = sb.ToString().Trim();

        int remainingWords = numberOfWords - 2;      
        
        for(int i = 1; i < remainingWords; i++)
        {
           
        }
        return sb.ToString();
    }
}