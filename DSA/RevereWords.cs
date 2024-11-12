using System.Text;

public class ReverseWord
{
    public string ReverseWords(string s) {
        string[] inputString = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        StringBuilder sb = new StringBuilder();

        for(int i = inputString.Length -1; i >= 0; i--)
        {
            sb.Append($"{inputString[i]} ");
        }

        return sb.ToString().TrimEnd();
    }
}