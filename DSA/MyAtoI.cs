using System.Text;

public class MyAtoI
{
    public int MyAtoi(string s) 
    {
        s = s.Trim();
        int count = 0;
        bool breakFlag = false, isNegative = false;
        StringBuilder sb = new();
        foreach(char letter in s)
        {
            switch(letter)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    breakFlag = false;
                    count++;
                    sb.Append(letter);
                    break;
                case '+':
                    if(count > 0)
                    {
                        breakFlag = true;
                        break;
                    }
                    continue;
                case '-' :
                    if(count > 0)
                    {
                        breakFlag = true;
                        break;
                    }
                    count++;
                    isNegative = true;
                    continue;
                case '.' :
                    if(count > 0)
                    {
                        breakFlag = true;
                        break;
                    }
                    break;
                default:
                    if(count > 0 || count == 0)
                    {
                        breakFlag = true;
                        break;
                    }
                    break;

            }

            if(breakFlag) break;
        }

        long.TryParse(sb.ToString(), out long number);
        if(number <= int.MinValue)
            number = int.MinValue;
        if(number >= int.MaxValue)
            number = int.MaxValue;

        return isNegative ? (int)-number : (int)number;
    }
}