using System.ComponentModel;
using System.Text;

public class DecimalToBinary
{
    public void DecToBinary(int n)
    {
        string bin = "";

        while(n > 0)
        {
            int remainder = n%2;
            bin = remainder.ToString() + bin;
            n /=2;
        }
        Console.WriteLine(bin);

        int count = 0;
        foreach(char item in bin)
        {
            if(item=='1')
                count++;
        }
        Console.WriteLine(count);
    }
}