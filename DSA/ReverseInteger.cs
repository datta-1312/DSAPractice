using System.Text;

public class ReverseInteger
{
    public int Reverse(int x) {
        List<int> lst = new();
        bool isNegative = false;
        if(x < 0)
        {
            isNegative = true;
            x = -x;
        }
        while(x > 0)
        {
            lst.Add(x % 10);
            x /= 10;
        }
        //lst.Reverse();

        StringBuilder sb = new();
        for(int i = 0; i < lst.Count; i++)
        {
            sb.Append(lst[i]);
        }
        int reversedNum = 0;
        int.TryParse(sb.ToString(),out reversedNum);
        return isNegative ? -reversedNum: reversedNum;
    }
}