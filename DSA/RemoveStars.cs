using System.Text;

public class RemoveStarsInString
{
    public string RemoveStars(string s) {
        StringBuilder sb = new StringBuilder(s);
        //StringBuilder sb1 = new StringBuilder();
        // Stack<char> stack = new Stack<char>();
        int i = 0;
        while(i < sb.Length)
        {
            if(sb[i]=='*')
            {
                sb = sb.Remove(i-1,2);
                i--;
                continue;
            }
            //sb1.Append(sb[i++]);
            i++;
        }

        return sb.ToString();
    }
}