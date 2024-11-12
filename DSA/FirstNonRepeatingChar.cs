public class FirstNonRepeating
{
    public void FindFirstNonRepeating(char[] inputArray)
    {
        Dictionary<char,int> dictionary = new Dictionary<char,int>();
        

        foreach (var charItem in inputArray)
        {
            if(dictionary.ContainsKey(charItem))
            {
                dictionary[charItem]++;
                continue;
            }
            dictionary.Add(charItem, 1);
        }

        foreach (var charItem in dictionary.Keys)
        {
            if(dictionary[charItem] == 1)
            {
                Console.WriteLine("First non repeacting character is {0}", charItem);
                return;
            }
        }
        Console.WriteLine("There are no non repeating character in the given input array");
    }
}