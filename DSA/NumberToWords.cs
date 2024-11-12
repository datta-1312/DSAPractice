using System.ComponentModel;
using System.Globalization;

public class NumberToWords
{
    public void ConvertNumberToWords(int number)
    {
        Dictionary<string,string> dict = new()
        {
            { "1", "One" },
            { "2", "Two" },
            { "3", "Three" },
            { "4", "Four" },
            { "5", "Five" },
            { "6", "Six" },
            { "7", "Seven" },
            { "8", "Eight" },
            { "9", "Nine" },
            { "10", "Ten" },
            { "11", "Eleven" },
            { "12", "Twelve" },
            { "13", "Thirteen" },
            { "14", "Fourteen" },
            { "15", "Fifteen" },
            { "16", "Sixteen" },
            { "17", "Seventeen" },
            { "18", "Eighteen" },
            { "19", "Nineteen" },
            { "20", "Twenty" },
            { "30", "Thirty" },
            { "40", "Fourty" },
            { "50", "Fifty" },
            { "60", "Sixty" },
            { "70", "Seventy" },
            { "80", "Eighty" },
            { "90", "Ninety" },
            { "100", "Hundred" },
            { "200", "Two Hundred" },
            { "300", "Three Hundred" },
            { "400", "Four Hundred" },
            { "500", "Five Hundred" },
            { "600", "Six Hundred" },
            { "700", "Seven Hundred" },
            { "800", "Eight Hundred" },
            { "900", "Nine Hundred" },
            { "1000", "One Thousand" }
        };
        int len = number.ToString().Length;
        int i = 0;
        while(i < len) 
        {
            int quotient = number / 10;
        }
    }
}