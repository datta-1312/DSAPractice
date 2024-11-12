using System.Text;

public class MakeGoodString
{
    public string MakeGood(string s) {
       StringBuilder sb = new StringBuilder(s);
        int length = s.Length-1;
        if(length == 0) return s;
        int i = 0;
        while(i<length)
        {
            if(Math.Abs(sb[i]-sb[i+1]) == 32)
            {
                sb = sb.Replace($"{sb[i]}{sb[i+1]}",string.Empty);
                i=0;
                length = sb.Length;
                continue;
            }
            i++;
        }
        return sb.ToString();
    }
}