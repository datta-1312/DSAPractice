using System.Text;

public class PlusOneClass {
    public int[] PlusOne(int[] digits) {
        StringBuilder sb = new StringBuilder();
        foreach(int i in digits)
        {
            sb.Append(i.ToString());
        }
        int num = Convert.ToInt32(sb.ToString());
        num +=1;
        sb.Clear();
        sb.Append(num.ToString());
        int[] result = new int[sb.Length];
        for(int i = 0; i < sb.Length; i++)
        {
            result[i] = Convert.ToInt32(sb[i].ToString());
        }

        return result;
    }
}