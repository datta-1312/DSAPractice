public class GoodLargestInteger
{
    public string LargestGoodInteger(string num) {
        // if(num.Length == 3)
        // {
        //     if((num[0] == num[1]) && (num[1]==num[2])) return num;

        //     return string.Empty;
        // }
        int currentMax=int.MinValue;
        string maxSubString=string.Empty;
        int previousMax = currentMax;
        for(int i=0;i < num.Length-2;i++)
        {
            if((num[i] == num[i+1]) && (num[i+1]==num[i+2]))
            {
                currentMax = Convert.ToInt32($"{num[i]}{num[i+1]}{num[i+2]}");
                string currentMaxString = $"{num[i]}{num[i+1]}{num[i+2]}";
                if(previousMax < currentMax)
                {
                    maxSubString = currentMaxString;
                    previousMax = currentMax;
                }
            }
            
        }
        return maxSubString;
    }
}