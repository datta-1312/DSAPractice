using System.Globalization;

public class PatternPrint
{
    public void Print(int input)
    {
        int[] array = new int[input];
        for(int i = 1,j = 0; j < input; i++, j++)
        {
            array[j] = i;
        }
        for(int i = 0; i < input; i++)
        {
            for(int j = i; j < input;)
            {
                Console.Write(array[j]);
                j++;
                if(j == input && i > 0)
                {
                    j = 0;
                }
                if(j == i && i > 0)
                {
                    break;
                }
            }
            
            Console.WriteLine();
        }
    }
}