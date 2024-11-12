public class Anagram
{
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        char[] sCharArray = s.ToCharArray();
        char[] tCharArray = t.ToCharArray();
        Array.Sort(sCharArray);
        Array.Sort(tCharArray);
        bool result =  tCharArray.SequenceEqual(sCharArray);
        return result;
        // if(new string(sCharArray)==new string(tCharArray))
        //     return true;
        // return false;
    }
}