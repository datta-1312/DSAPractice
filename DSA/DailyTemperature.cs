public class DailyTemperature
{
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> stk = new();
        int[] output = new int[temperatures.Length];
        int daysCount = 0;
        for(int i = 1,j = 0; j < temperatures.Length; i++)
        {
            if(i < temperatures.Length && temperatures[j] < temperatures[i])
            {
                daysCount++;
            }
            if(i < temperatures.Length && temperatures[j] >= temperatures[i])
            {
                daysCount++;
                continue;
            }
            if(i >= temperatures.Length)
                daysCount = 0;
            output[j++] = daysCount;
            i = j;
            daysCount = 0;
        }
        return output;
    }
}