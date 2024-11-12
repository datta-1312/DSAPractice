using System.Text;

public class Palindrome
{
    public bool IsPalindrome(string s) {
        StringBuilder str= new StringBuilder();

        foreach(char charItem in s.ToLower())
        {
            if(char.IsLetter(charItem))
            {
                str.Append(charItem);
            }
        }
        string appendedString = str.ToString();
        foreach(char charItem in appendedString)
        {
            if(char.IsLetter(charItem))
            {
                //str.Append(charItem);
            }
        }
        for(int i=0,j=appendedString.Length-1;i<appendedString.Length;i++,j--)
        {
            if(appendedString[i]!=appendedString[j])
                return false;
        }
        return true;
    }
}