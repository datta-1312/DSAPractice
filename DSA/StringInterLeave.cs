public class StringInterleave
{
    public bool IsInterleave(string s1, string s2, string s3) {
        int firstPtr = 0, secondPtr = 0,s3Ptr = 0, redun = 0;;
        bool isFlipped = false;
        while(firstPtr < s1.Length && secondPtr < s2.Length)
        {
            if(s1[firstPtr] == s3[s3Ptr] && !isFlipped)
            {
                redun = 0;
                s3Ptr++;
                firstPtr++;
                continue;
            }
            isFlipped = true;
            if(s2[secondPtr] == s3[s3Ptr] && isFlipped)
            {
                redun = 0;
                s3Ptr++;
                secondPtr++;
                continue;
            }
            isFlipped = false;
            redun++;
            if(redun == 2)
                return false;
        }

        while(firstPtr < s1.Length && s3Ptr < s3.Length )
        {
            if(s1[firstPtr] == s3[s3Ptr])
            {
                s3Ptr++;
                firstPtr++;
                continue;
            }
            return false;
        }

        while(secondPtr < s2.Length & s3Ptr < s3.Length)
        {
            if(s2[secondPtr] == s3[s3Ptr])
            {
                s3Ptr++;
                secondPtr++;
                continue;
            }
            return false;
        }
        
        return (firstPtr+secondPtr) == s3Ptr;
    }
}