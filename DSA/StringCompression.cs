public class StringCompression
{
    public int Compress(char[] chars) {
        if(chars.Length == 1)
            return 1;
        int slow = 0,fast = 1;
        List<char> list = new();
        
        while(slow < chars.Length)
        {
            if(chars[slow] == chars[fast])
            {
                list.Add(chars[slow]);
                while(fast < chars.Length && chars[slow]==chars[fast])
                {
                    fast++;
                }
                list.Add(Convert.ToChar(fast-slow));
                slow = fast;
            }
        }
        
        return list.Count;
    }
}