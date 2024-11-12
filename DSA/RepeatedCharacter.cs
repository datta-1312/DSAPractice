public class RepeatedChar
{
    public char RepeatedCharacter(string s) {
        var dictionary = new Dictionary<char,int>();
        char result = ' ';
        char previousChar = s[0];
        for(int i = 1; i<s.Length;i++)
        {
            if(previousChar == s[i])
            {
                return previousChar;
            }
            char temp = s[i];
            previousChar = temp;
        }

        foreach(var itemChar in s)
        {
            if(dictionary.ContainsKey(itemChar))
            {
                //dictionary[itemChar]++;
                result = itemChar;
                break;
            }
            dictionary.Add(itemChar,1);
        }
        return result;
    }
}