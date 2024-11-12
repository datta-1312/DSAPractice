public class LargestAltitudePrefixSum
{
    public int LargestAltitude(int[] gain) {

        int[] prefixArray = new int[gain.Length+1];
        prefixArray[0] = 0;
        for(int i = 1; i < gain.Length; i++)
        {
            prefixArray[i] = prefixArray[i-1]+gain[i-1];
        }

        return prefixArray.Max();
    }
}