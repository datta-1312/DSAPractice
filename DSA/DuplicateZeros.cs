public class DuplicateZero
{
    public void DuplicateZeros(int[] arr) {
        int[] result = new int[arr.Length];
        for(int i = 0; i < arr.Length-2;)
        {
            int left = i;
            if(arr[i] == 0)
            {
                result[++left] = arr[i];
                if(arr[i+1] > 0)
                    result[++left] = arr[i+1];
                i = left;
                i++;
                continue;
            }
            result[left++] = arr[i++];
        }

        Array.Copy(result,arr,arr.Length);
    }
}